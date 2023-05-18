using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ACS.SPiiPlusNET;  // ACS MOTION 

namespace ACSMotion
{

    internal class CACSMMotion
    {   
        static Api channel;

        public CACSM[] m_pACSMotion;

        public void IsOpend()
        {

        }

        public void InitOnce(int nMotCount)
        {
            channel = new Api();

            if (m_pACSMotion == null)
            {
                m_pACSMotion = new CACSM[nMotCount];
            }
        }

        public void InitOpen(string address, int nPort)
        {
            channel.OpenCommEthernetTCP(address, nPort);
            //channel.OpenCommSimulator();
        }

        public void SetGroup(int nAxis1, int nAxis2)
        {
            Axis[] axes = { (Axis)nAxis1, (Axis)nAxis2 , Axis.ACSC_NONE};
            channel.Group(axes);
        }

        public struct CACSM
        {
            public int nAxis;
            public string strAxisName;

            public double dVel;
            public double dAcc;
            public double dDec;
            public double dKillDec;
            public double dJerk;

            public double dMinPos;
            public double dMaxPos;

            public int nHomeIdx;
            public string strHomeBuffer;
            public double dHomeOffset;

            public void SetVelocity(double dVelocity)
            {
                channel.SetVelocity((Axis)nAxis, dVelocity);
                channel.SetAcceleration((Axis)nAxis, dVelocity * 5);
                channel.SetDeceleration((Axis)nAxis, dVelocity * 5);
                channel.SetKillDeceleration((Axis)nAxis, dVelocity * 15);
                channel.SetJerk((Axis)nAxis, dVelocity * 15);
            }

            public void SetEnable(bool bCase)
            {
                if (bCase)
                {
                    channel.Enable((Axis)nAxis);

                    if (nAxis == 1)
                        channel.Enable(Axis.ACSC_AXIS_3);
                }

                else
                {
                    channel.Disable((Axis)nAxis);

                    if (nAxis == 1)
                        channel.Disable(Axis.ACSC_AXIS_3);
                }

            }
            
            public MotorStates IsEnable()
            {
                MotorStates state = channel.GetMotorState((Axis)nAxis);

                return state;
            }

            public void RunHome()
            {
                channel.RunBuffer((ProgramBuffer)nHomeIdx, null);
            }

            public MotorStates IsMotorState()
            {
                MotorStates state = channel.GetMotorState((Axis)nAxis);

                return state;
            }

            public int GetHomeFlags()
            {
                int nState;

                try
                {
                    nState = (int)channel.ReadVariable(strHomeBuffer, ProgramBuffer.ACSC_NONE);

                    return nState;

                }
                catch (InvalidOperationException e)
                {
                    
                    return 0;
                }
            }

            public double GetReferencePos()
            {
                double fPosition = channel.GetRPosition((Axis)nAxis);
                // Asynchronous get motor feedback position
                ACSC_WAITBLOCK wb = channel.GetRPositionAsync((Axis)nAxis);
                fPosition = (double)channel.GetResult(wb, 2000);

                return fPosition;
            }

            public int GetActualPos()
            {
                int nPos;

                try
                {
                    uint address = channel.GetSharedMemoryAddress(ProgramBuffer.ACSC_NONE, "intVariable");

                    double[] realResults = new double[4];

                    realResults = (double[])channel.ReadSharedMemoryReal(address, 0, 1, 0, 1);
                    nPos = (int)channel.GetSharedMemoryAddress(ProgramBuffer.ACSC_BUFFER_1, "APOS");

//                    nPos = (int)channel.ReadVariableAsScalar("APOS", ProgramBuffer.ACSC_NONE, -1, -1);
                    return nPos;
                }

                catch
                {
                    return 0;
                }
            }

            public void MoveABS(double dTargetPos)
            {
                channel.ToPoint(MotionFlags.ACSC_NONE, (Axis)nAxis, dTargetPos);
            }

            public void MoveREL(double dTargetPos)
            {
                channel.ToPoint(MotionFlags.ACSC_AMF_RELATIVE, (Axis)nAxis, dTargetPos);
            }

            public void MoveStop()
            {
                channel.Kill((Axis)nAxis);
            }

        }
    }
}
