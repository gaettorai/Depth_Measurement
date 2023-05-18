using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

using WDI;              // AF 
using ACS.SPiiPlusNET;  // ACS MOTION 
using Matrox.MatroxImagingLibrary;  // MIL LIBRARY
using OpenCvSharp;

using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;

namespace ACSMotion
{
    public partial class Form1 : Form
    {
        int nMotCount;          // MOTION 축 갯수

        double dCommandX;       // MOTION X COMMAND 위치
        double dCommandY;       // MOTION Y COMMAND 위치
        double dCommandT;       // MOTION T COMMAND 위치

        int nSelectedPreset = 0;    // MOTION PRESET SELECT

        Thread statusThread;    // MOTION THREAD

        public bool bCheckPresetMoveX = false;  // 순차적으로 이동 시 변수
        public bool bCheckPresetMoveY = false;
        public bool bCheckPresetMoveT = false;

        public int nATFCount = 0;   // ATF 이동 현재 COUNT

        double dATFPitch = 0.5;      // ATF 이동 PITCH

        double dStep = 0.25;       // ATF 이동 Step 간격
        int nStepCount;         // ATF 이동 횟수

        public int nStartPos;   // process atf 시작 위치
        public int nEndPos;     // process atf 종료 위치
        public int nCurrentPos; // process atf 현재 위치

        Thread atfThread;       // ATF THREAD

        public bool bCheckProcess = false;  // 순차적으로 이동 시 변수
        public bool bReadyATFpos = false;   // process 진행 시 atf 초기 위치 이동 확인

        public int nGrabCount = 0;

        Thread processThread;   // PROCESS THREAD

        int nImageSplit;        // 분석 시 mask size
        int nAnalysisCount;     // 분석 진행 count

        int[] dResultBest;
        double[] dResultBestPosition;
        double[] dResultBestValue;
        double[,] heightData;

        public System.Drawing.Color[] colors = new System.Drawing.Color[255];

        bool bCheckClick = false;

        int nClickCount = 0;

        double dGradient;
        double dIntercept;

        System.Drawing.Point pFirstPoint;
        System.Drawing.Point pSecondPoint;

        double dXFirst_1 = 0.0;
        double dXSecond_1 = 0.0;
        double dXFirst_2 = 0.0;
        double dXSecond_2 = 0.0;
        double dXFirst_3 = 0.0;
        double dXSecond_3 = 0.0;

        double dYFirst = 0.0;
        double dYSecond = 0.0;

        public bool bCheckMoveLeft1 = false;
        public bool bCheckMoveLeft2 = false;
        public bool bCheckMoveLeft3 = false;
        public bool bCheckMoveRight1 = false;
        public bool bCheckMoveRight2 = false;
        public bool bCheckMoveRight3 = false;
        public bool bCheckMoveTop = false;
        public bool bCheckMoveBottom = false;

        public Rectangle MergeLeftRectX1 = new Rectangle(0, 0, 1, 512);
        public Rectangle MergeRightRectX1 = new Rectangle(512, 0, 1, 512);
        public Rectangle MergeLeftRectX2 = new Rectangle(0, 0, 1, 512);
        public Rectangle MergeRightRectX2 = new Rectangle(512, 0, 1, 512);
        public Rectangle MergeLeftRectX3 = new Rectangle(0, 0, 1, 512);
        public Rectangle MergeRightRectX3 = new Rectangle(512, 0, 1, 512);

        public Rectangle LeftRectX1 = new Rectangle(30, 14, 1, 240);
        public Rectangle RightRectX1 = new Rectangle(540, 14, 1, 240);
        public Rectangle LeftRectX2 = new Rectangle(30, 14, 1, 240);
        public Rectangle RightRectX2 = new Rectangle(540, 14, 1, 240);
        public Rectangle LeftRectX3 = new Rectangle(30, 14, 1, 240);
        public Rectangle RightRectX3 = new Rectangle(540, 14, 1, 240);

        public Rectangle TopRectY = new Rectangle(30, 14, 510, 1);
        public Rectangle BottomRectY = new Rectangle(30, 254, 510, 1);

        public static bool bMouseInLeft1 { get; set; }
        public static bool bMouseInLeft2 { get; set; }
        public static bool bMouseInLeft3 { get; set; }
        public static bool bMouseInRight1 { get; set; }
        public static bool bMouseInRight2 { get; set; }
        public static bool bMouseInRight3 { get; set; }
        public static bool bMouseInTop { get; set; }
        public static bool bMouseInBottom { get; set; }

        public bool bCheckConfirmLeft1 = false;
        public bool bCheckConfirmLeft2 = false;
        public bool bCheckConfirmLeft3 = false;
        public bool bCheckConfirmRight1 = false;
        public bool bCheckConfirmRight2 = false;
        public bool bCheckConfirmRight3 = false;
        public bool bCheckConfirmTop = false;
        public bool bCheckConfirmBottom = false;

        public Bitmap BmpColorMap;
        public Bitmap BmpMerge;
        public Bitmap BmpColor;

        public int nSelectedDisplay = 0;

        // MIL LIBRARY 변수
        public MIL_ID MilApplication = MIL.M_NULL;  // MIL Application identifier.
        public MIL_ID MilSystem = MIL.M_NULL;       // MIL System identifier.
        public MIL_ID MilDisplay = MIL.M_NULL;      // MIL Display identifier.
        public MIL_ID MilDigitizer = MIL.M_NULL;    // MIL Digitizer identifier.
        public MIL_ID MilImage = MIL.M_NULL;        // MIL Image buffer identifier.
        public MIL_INT BufSizeX = 2048;
        public MIL_INT BufSizeY = 2048;
        public MIL_INT BufSizeBand = 1;

        // 이미지 저장 시 시간 정보
        string strData;
        string strDay;
        string strTime;

        public struct _ACS_COMMM_CONFIG
        {
            public string strIP;
            public int nPort;
        }

        public struct _PRESET_CONFIG
        {
            public double dPosX;
            public double dPosY;
            public double dPosT;
        }

        public struct stResult
        {
            public double[] dAVGValue;
        }

        public struct stImage
        {
            public Bitmap bmpImg;
        }


        CACSMMotion pACS;

        _ACS_COMMM_CONFIG CommConfig;
        _PRESET_CONFIG[] PresetConfig;

        public stResult[] ResultConfig;
        public stImage[] ImageConfig;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        public Form1()
        {
            InitializeComponent();

            InitColorMap();
            result_Graph_Init();
            processThread = new Thread(new ThreadStart(ProcessElapsed));
            processThread.Start();
        }

        public void InitColorMap()
        {
            Random rand = new Random();
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = System.Drawing.Color.FromArgb(i, 0, colors.Length - i);
            }

            // 색상 맵 생성
            System.Drawing.Image colorMap = new Bitmap(10, colors.Length);
            for (int x = 0; x < colors.Length; x++)
            {
                ((Bitmap)colorMap).SetPixel(0, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(1, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(2, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(3, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(4, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(5, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(6, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(7, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(8, x, colors[x]);
                ((Bitmap)colorMap).SetPixel(9, x, colors[x]);

            }
            BmpColorMap = new Bitmap("colorMap.bmp");
            pictureBox_colormap_2.Image = BmpColorMap;

            pictureBox_colormap.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button_process_start_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DEPTH MEASURE PROCESS START?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CreateFolder();

                if (comboBox_wdi_image_split.SelectedIndex == 0) nImageSplit = 2;
                else if (comboBox_wdi_image_split.SelectedIndex == 1) nImageSplit = 4;
                else if (comboBox_wdi_image_split.SelectedIndex == 2) nImageSplit = 8;
                else if (comboBox_wdi_image_split.SelectedIndex == 3) nImageSplit = 16;
                else if (comboBox_wdi_image_split.SelectedIndex == 4) nImageSplit = 32;
                else if (comboBox_wdi_image_split.SelectedIndex == 5) nImageSplit = 64;
                else if (comboBox_wdi_image_split.SelectedIndex == 6) nImageSplit = 128;

                nCurrentPos = (int)(Convert.ToDouble(textBox_wdi_current_pos.Text.ToString()) * 4);
                nStartPos = (int)(Convert.ToDouble(textBox_wdi_set_low.Text.ToString()) * 4);
                nEndPos = (int)(Convert.ToDouble(textBox_wdi_set_high.Text.ToString()) * 4);

                nStepCount = Math.Abs((nEndPos - nStartPos) / (int)(dStep * 4)) + 1;

                ResultConfig = new stResult[nStepCount];
                ImageConfig = new stImage[nStepCount];

                ATF.ATF_MoveZ((int)(nStartPos - nCurrentPos));
                bReadyATFpos = true;
                bCheckProcess = true;
            }

            else
            {

            }
        }

        private void button_process_stop_Click(object sender, EventArgs e)
        {
            // 공정 정지? 
            // 공정 일시 정지?
        }

        public void StatusElapsed()
        {
            Bitmap bmpRed;
            Bitmap bmpGreen;
            Bitmap bmpYellow;

            bmpRed = new Bitmap(Application.StartupPath + @"\Res" + "\\RedLED.bmp");
            bmpGreen = new Bitmap(Application.StartupPath + @"\Res" + "\\GreenLED.bmp");
            bmpYellow = new Bitmap(Application.StartupPath + @"\Res" + "\\YellowLED.bmp");

            while (true)
            {
                // PRESET 이동 관련
                if (bCheckPresetMoveT)
                {
                    pACS.m_pACSMotion[0].MoveABS(Convert.ToDouble(textBox_motion_preset_pos_t.Text.ToString()));
                    bCheckPresetMoveT = false;
                    bCheckPresetMoveX = true;
                }

                if (bCheckPresetMoveX)
                {
                    if (!Convert.ToBoolean(MotorStates.ACSC_MST_MOVE & pACS.m_pACSMotion[0].IsMotorState()))
                    {
                        pACS.m_pACSMotion[1].MoveABS(Convert.ToDouble(textBox_motion_preset_pos_x.Text.ToString()));
                        bCheckPresetMoveX = false;
                        bCheckPresetMoveY = true;
                    }
                }

                if (bCheckPresetMoveY)
                {
                    if (!Convert.ToBoolean(MotorStates.ACSC_MST_MOVE & pACS.m_pACSMotion[1].IsMotorState()))
                    {
                        pACS.m_pACSMotion[2].MoveABS(Convert.ToDouble(textBox_motion_preset_pos_x.Text.ToString()));
                        bCheckPresetMoveY = false;
                    }
                }

                // t축 관련 내용
                if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[0].IsMotorState()))
                {
                    pictureBox_motion_status_t_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_enable.Image = bmpGreen; }));

                    button_motion_t_move.Invoke(new EventHandler(delegate
                    { button_motion_t_move.Enabled = true; }));
                }

                else
                {
                    pictureBox_motion_status_t_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_enable.Image = bmpRed; }));

                    button_motion_t_move.Invoke(new EventHandler(delegate
                    { button_motion_t_move.Enabled = false; }));
                }

                if (Convert.ToBoolean(MotorStates.ACSC_MST_MOVE & pACS.m_pACSMotion[0].IsMotorState()))
                {
                    pictureBox_motion_status_t_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_moving.Image = bmpGreen; }));

                    button_motion_t_move.Invoke(new EventHandler(delegate { button_motion_t_move.Text = "STOP"; }));
                }

                else
                {
                    pictureBox_motion_status_t_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_moving.Image = bmpRed; }));

                    button_motion_t_move.Invoke(new EventHandler(delegate { button_motion_t_move.Text = "MOVE"; }));
                }

                if ((pACS.m_pACSMotion[0].GetHomeFlags()) == 0)
                    pictureBox_motion_status_t_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_homedone.Image = bmpRed; }));

                if ((pACS.m_pACSMotion[0].GetHomeFlags()) == 1)
                    pictureBox_motion_status_t_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_homedone.Image = bmpGreen; }));

                else if ((pACS.m_pACSMotion[0].GetHomeFlags()) == 2)
                    pictureBox_motion_status_t_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_homedone.Image = bmpYellow; }));

                else if ((pACS.m_pACSMotion[0].GetHomeFlags()) == 3)
                    pictureBox_motion_status_t_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_homedone.Image = bmpRed; }));

                else if ((pACS.m_pACSMotion[0].GetHomeFlags()) == 4)
                    pictureBox_motion_status_t_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_t_homedone.Image = bmpRed; }));


                // x축 관련 내용
                if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[1].IsMotorState()))
                {
                    pictureBox_motion_status_x_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_enable.Image = bmpGreen; }));

                    button_motion_x_move.Invoke(new EventHandler(delegate
                    { button_motion_x_move.Enabled = true; }));
                }

                else
                {
                    pictureBox_motion_status_x_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_enable.Image = bmpRed; }));

                    button_motion_x_move.Invoke(new EventHandler(delegate
                    { button_motion_x_move.Enabled = false; }));
                }

                if (Convert.ToBoolean(MotorStates.ACSC_MST_MOVE & pACS.m_pACSMotion[1].IsMotorState()))
                {
                    pictureBox_motion_status_x_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_moving.Image = bmpGreen; }));

                    button_motion_x_move.Invoke(new EventHandler(delegate { button_motion_x_move.Text = "STOP"; }));
                }

                else
                {
                    pictureBox_motion_status_x_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_moving.Image = bmpRed; }));

                    button_motion_x_move.Invoke(new EventHandler(delegate { button_motion_x_move.Text = "MOVE"; }));
                }

                if ((pACS.m_pACSMotion[1].GetHomeFlags()) == 0)
                    pictureBox_motion_status_x_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_homedone.Image = bmpRed; }));

                if ((pACS.m_pACSMotion[1].GetHomeFlags()) == 1)
                    pictureBox_motion_status_x_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_homedone.Image = bmpGreen; }));

                else if ((pACS.m_pACSMotion[1].GetHomeFlags()) == 2)
                    pictureBox_motion_status_x_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_homedone.Image = bmpYellow; }));

                else if ((pACS.m_pACSMotion[1].GetHomeFlags()) == 3)
                    pictureBox_motion_status_x_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_homedone.Image = bmpRed; }));

                else if ((pACS.m_pACSMotion[1].GetHomeFlags()) == 4)
                    pictureBox_motion_status_x_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_x_homedone.Image = bmpRed; }));

                // y축 관련 내용
                if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[2].IsMotorState()))
                {
                    pictureBox_motion_status_y_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_enable.Image = bmpGreen; }));

                    button_motion_y_move.Invoke(new EventHandler(delegate
                    { button_motion_y_move.Enabled = true; }));
                }

                else
                {
                    pictureBox_motion_status_y_enable.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_enable.Image = bmpRed; }));

                    button_motion_y_move.Invoke(new EventHandler(delegate
                    { button_motion_y_move.Enabled = false; }));
                }

                if (Convert.ToBoolean(MotorStates.ACSC_MST_MOVE & pACS.m_pACSMotion[2].IsMotorState()))
                {
                    pictureBox_motion_status_y_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_moving.Image = bmpGreen; }));

                    button_motion_y_move.Invoke(new EventHandler(delegate { button_motion_y_move.Text = "STOP"; }));
                }

                else
                {
                    pictureBox_motion_status_y_moving.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_moving.Image = bmpRed; }));

                    button_motion_y_move.Invoke(new EventHandler(delegate { button_motion_y_move.Text = "MOVE"; }));
                }



                if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[0].IsMotorState()) &&
                    Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[1].IsMotorState()) &&
                    Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[2].IsMotorState()))
                {
                    button_motion_preset_move.Invoke(new EventHandler(delegate
                    { button_motion_preset_move.Enabled = true; }));

                    button_motion_cycle_move.Invoke(new EventHandler(delegate
                    { button_motion_cycle_move.Enabled = true; }));
                }

                else
                {
                    button_motion_preset_move.Invoke(new EventHandler(delegate
                    { button_motion_preset_move.Enabled = false; }));

                    button_motion_cycle_move.Invoke(new EventHandler(delegate
                    { button_motion_cycle_move.Enabled = false; }));
                }

                if ((pACS.m_pACSMotion[2].GetHomeFlags()) == 0)
                    pictureBox_motion_status_y_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_homedone.Image = bmpRed; }));

                if ((pACS.m_pACSMotion[2].GetHomeFlags()) == 1)
                    pictureBox_motion_status_y_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_homedone.Image = bmpGreen; }));

                else if ((pACS.m_pACSMotion[2].GetHomeFlags()) == 2)
                    pictureBox_motion_status_y_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_homedone.Image = bmpYellow; }));

                else if ((pACS.m_pACSMotion[2].GetHomeFlags()) == 3)
                    pictureBox_motion_status_y_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_homedone.Image = bmpRed; }));

                else if ((pACS.m_pACSMotion[2].GetHomeFlags()) == 4)
                    pictureBox_motion_status_y_homedone.Invoke(new EventHandler(delegate
                    { pictureBox_motion_status_y_homedone.Image = bmpRed; }));

                textBox_motion_x_actual.Invoke(new EventHandler(delegate
                { textBox_motion_x_actual.Text = (pACS.m_pACSMotion[1].GetReferencePos().ToString("F4")); }));

                textBox_motion_y_actual.Invoke(new EventHandler(delegate
                { textBox_motion_y_actual.Text = (pACS.m_pACSMotion[2].GetReferencePos().ToString("F4")); }));

                textBox_motion_t_actual.Invoke(new EventHandler(delegate
                { textBox_motion_t_actual.Text = (pACS.m_pACSMotion[0].GetReferencePos().ToString("F4")); }));
            }
        }

        public void ATFElapsed()
        {
            int nPosition = 0;
            double dPosition = 0.0;
            while (true)
            {
                ATF.ATF_ReadAbsZPos(out nPosition);
                if (nPosition != 0)
                    dPosition = nPosition * 0.25;

                textBox_wdi_current_pos.Invoke(new EventHandler(delegate
                { textBox_wdi_current_pos.Text = dPosition.ToString("F2"); }));
            }
        }

        public void ProcessElapsed()
        {
            int nInpos = 0;

            while (true)
            {
                if (bCheckProcess)
                {
                    if (!bReadyATFpos)
                    {
                        ATF.ATF_ReadAbsZPos(out nInpos);

                        // ATF Unit start 위치 이동 완료
                        if (nInpos == nStartPos)
                        {
                            bReadyATFpos = true;
                            Thread.Sleep(1000);
                        }
                        //bReadyATFpos = true;

                    }

                    else
                    {
                        if (nATFCount < nStepCount)
                        {
                            Thread.Sleep(1000);

                            ImageSave(nGrabCount);
                            ImageAnalysis(nGrabCount);
                            nGrabCount++;

                            if (nATFCount < nStepCount - 1)
                            {
                                // 위치 이동
                                ATF.ATF_MoveZ((int)(dStep * 4));
                            }

                            textBox_process_percent.Invoke(new EventHandler(delegate
                            { textBox_process_percent.Text = "분석 진행 중 : " + nGrabCount.ToString(); }));

                            nATFCount++;
                        }

                        else if (nATFCount == nStepCount)
                        {
                            ResultAnalysis();
                            textBox_process_percent.Invoke(new EventHandler(delegate
                            { textBox_process_percent.Text = "ColorMapping... "; }));

                            ImageMappingColor();
                            textBox_process_percent.Invoke(new EventHandler(delegate
                            { textBox_process_percent.Text = "MergeMapping... "; }));

                            ImageMappingMerge();
                            textBox_process_percent.Invoke(new EventHandler(delegate
                            { textBox_process_percent.Text = "Complete"; }));

                            bReadyATFpos = false;
                            bCheckProcess = false;
                            nGrabCount = 0;
                            nATFCount = 0;
                        }
                    }
                }
            }
        }

        public void CreateFolder()
        {
            strData = Application.StartupPath + @"\DATA";
            strDay = strData + "\\" + DateTime.Today.ToString("yyMMdd");
            strTime = strDay + "\\" + DateTime.Now.ToString("HHmmss");

            DirectoryInfo diDay = new DirectoryInfo(strDay);
            DirectoryInfo diTime = new DirectoryInfo(strTime);

            try
            {
                if (!diDay.Exists) Directory.CreateDirectory(strDay);
                if (!diTime.Exists) Directory.CreateDirectory(strTime);
            }
            catch
            {

            }
        }

        private void button_motion_connect_Click(object sender, EventArgs e)
        {
            pACS = new CACSMMotion();
            pACS.InitOnce(3);

            readMotionParam();
            readMotionPreset();

            pACS.InitOpen(CommConfig.strIP, CommConfig.nPort);

            pACS.SetGroup(1, 3);

            statusThread = new Thread(new ThreadStart(StatusElapsed));
            statusThread.Start();

            buttonEnable(true);

        }

        public void buttonEnable(bool nCase)
        {
            pictureBox_motion_status_x_enable.Enabled = nCase;
            pictureBox_motion_status_y_enable.Enabled = nCase;
            pictureBox_motion_status_t_enable.Enabled = nCase;

            pictureBox_motion_status_x_moving.Enabled = nCase;
            pictureBox_motion_status_y_moving.Enabled = nCase;
            pictureBox_motion_status_t_moving.Enabled = nCase;

            pictureBox_motion_status_x_homedone.Enabled = nCase;
            pictureBox_motion_status_y_homedone.Enabled = nCase;
            pictureBox_motion_status_t_homedone.Enabled = nCase;

            toggle_move.Enabled = nCase;

            button_motion_preset_1.Enabled = nCase;
            button_motion_preset_2.Enabled = nCase;
            button_motion_preset_3.Enabled = nCase;
            button_motion_preset_4.Enabled = nCase;
            button_motion_preset_5.Enabled = nCase;
            button_motion_preset_6.Enabled = nCase;
            button_motion_preset_7.Enabled = nCase;
            button_motion_preset_8.Enabled = nCase;
            button_motion_preset_laser.Enabled = nCase;
            button_motion_preset_vision.Enabled = nCase;
            button_motion_preset_depth.Enabled = nCase;

        }

        public void readMotionPreset()
        {
            StringBuilder strData = new StringBuilder();
            string strFile = Application.StartupPath + @"\Config\MotionPreset.ini";

            PresetConfig = new _PRESET_CONFIG[11];

            string strTag;
            for (int i = 0; i < 11; i++)
            {
                if (i == 8)
                    strTag = "LASER";

                else if (i == 9)
                    strTag = "VISION";

                else if (i == 10)
                    strTag = "DEPTH";
                else
                    strTag = "PRESET" + i.ToString();

                GetPrivateProfileString(strTag, "STAGE X", "", strData, 32, strFile);
                PresetConfig[i].dPosX = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "STAGE Y", "", strData, 32, strFile);
                PresetConfig[i].dPosY = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "TURN", "", strData, 32, strFile);
                PresetConfig[i].dPosT = Convert.ToDouble(strData.ToString());
            }

            button_motion_preset_init();

            nSelectedPreset = 0;

            button_motion_preset_pos();
            button_motion_preset_1.BackColor = Color.Lime;
            button_motion_preset_1.ForeColor = Color.White;
        }

        public void readMotionParam()
        {
            StringBuilder strData = new StringBuilder();
            string strFile = Application.StartupPath + @"\Config\\ACSMotion.ini";
            string strTag = "COMMON";

            GetPrivateProfileString(strTag, "STAGE NUM", "", strData, 32, strFile);
            nMotCount = Convert.ToInt16(strData.ToString());

            GetPrivateProfileString(strTag, "IP", "", strData, 32, strFile);
            CommConfig.strIP = strData.ToString();

            GetPrivateProfileString(strTag, "PORT", "", strData, 32, strFile);
            CommConfig.nPort = Convert.ToInt16(strData.ToString());

            for (int i = 0; i < nMotCount; i++)
            {
                strTag = "MOTION" + i.ToString();

                GetPrivateProfileString(strTag, "AXIS NUM", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].nAxis = Convert.ToInt16(strData.ToString());

                GetPrivateProfileString(strTag, "AXIS NAME", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].strAxisName = strData.ToString();

                GetPrivateProfileString(strTag, "VEL", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dVel = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "ACC", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dAcc = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "DEC", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dDec = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "KILLDEC", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dKillDec = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "JERK", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dJerk = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "MIN POS", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dMinPos = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "MAX POS", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dMaxPos = Convert.ToDouble(strData.ToString());

                GetPrivateProfileString(strTag, "HOMEIDX", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].nHomeIdx = Convert.ToInt16(strData.ToString());

                GetPrivateProfileString(strTag, "HOMEBUFFER", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].strHomeBuffer = strData.ToString();

                GetPrivateProfileString(strTag, "HOMEOFFSET", "", strData, 32, strFile);
                pACS.m_pACSMotion[i].dHomeOffset = Convert.ToDouble(strData.ToString());
            }
        }

        private void pictureBox_motion_status_x_enable_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[1].IsEnable()))
            {
                if (MessageBox.Show("STAGE X DISABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[1].SetEnable(false);

                else
                {

                }
            }

            else
            {
                if (MessageBox.Show("STAGE X ENABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[1].SetEnable(true);

                else
                {

                }
            }
        }

        private void pictureBox_motion_status_x_homedone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("STAGE X HOME BUFFER RUN?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                pACS.m_pACSMotion[1].RunHome();

            else
            {

            }
        }

        private void pictureBox_motion_status_y_enable_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[2].IsEnable()))
            {
                if (MessageBox.Show("STAGE Y DISABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[2].SetEnable(false);

                else
                {

                }
            }

            else
            {
                if (MessageBox.Show("STAGE Y ENABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[2].SetEnable(true);

                else
                {

                }
            }
        }

        private void pictureBox_motion_status_y_homedone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("STAGE Y HOME BUFFER RUN?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                pACS.m_pACSMotion[2].RunHome();

            else
            {

            }
        }

        private void pictureBox_motion_status_t_enable_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(MotorStates.ACSC_MST_ENABLE & pACS.m_pACSMotion[0].IsEnable()))
            {
                if (MessageBox.Show("TURN DISABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[0].SetEnable(false);

                else
                {

                }
            }

            else
            {
                if (MessageBox.Show("TURN ENABLE?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pACS.m_pACSMotion[0].SetEnable(true);

                else
                {

                }
            }
        }

        private void pictureBox_motion_status_t_homedone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TURN HOME BUFFER RUN?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                pACS.m_pACSMotion[0].RunHome();

            else
            {

            }
        }

        private void toggle_move_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_move.Checked)
            {
                String strInput = textBox_motion_x_input.Text;

                if (double.TryParse(strInput, out dCommandX))
                {
                    textBox_motion_x_command.Invoke(new EventHandler(delegate
                    { textBox_motion_x_command.Text = (dCommandX + Convert.ToDouble(textBox_motion_x_actual.Text)).ToString("F3"); }));
                }

                strInput = textBox_motion_y_input.Text;

                if (double.TryParse(strInput, out dCommandY))
                {
                    textBox_motion_y_command.Invoke(new EventHandler(delegate
                    { textBox_motion_y_command.Text = (dCommandY + Convert.ToDouble(textBox_motion_y_actual.Text)).ToString("F3"); }));
                }


                strInput = textBox_motion_t_input.Text;

                if (double.TryParse(strInput, out dCommandT))
                {
                    textBox_motion_t_command.Invoke(new EventHandler(delegate
                    { textBox_motion_t_command.Text = (dCommandT + Convert.ToDouble(textBox_motion_t_actual.Text)).ToString("F3"); }));
                }
            }

            else
            {
                String strInput = textBox_motion_x_input.Text;

                if (double.TryParse(strInput, out dCommandX))
                {
                    textBox_motion_x_command.Invoke(new EventHandler(delegate
                    { textBox_motion_x_command.Text = dCommandX.ToString(); }));
                }

                strInput = textBox_motion_y_input.Text;

                if (double.TryParse(strInput, out dCommandY))
                {
                    textBox_motion_y_command.Invoke(new EventHandler(delegate
                    { textBox_motion_y_command.Text = dCommandY.ToString(); }));
                }

                strInput = textBox_motion_t_input.Text;

                if (double.TryParse(strInput, out dCommandT))
                {
                    textBox_motion_t_command.Invoke(new EventHandler(delegate
                    { textBox_motion_t_command.Text = dCommandT.ToString(); }));
                }
            }
        }

        private void button_motion_x_move_Click(object sender, EventArgs e)
        {
            double dCommandPosX;

            dCommandPosX = Convert.ToDouble(textBox_motion_x_command.Text.ToString());

            if (button_motion_x_move.Text == "MOVE")
            {
                if (pACS.m_pACSMotion[1].dMinPos > dCommandPosX || pACS.m_pACSMotion[1].dMaxPos < dCommandPosX)
                {
                    MessageBox.Show("X Axis Moving Position Error (Moving Range Over)", "ACSMotioen");
                }

                else
                {
                    pACS.m_pACSMotion[1].SetVelocity(Convert.ToDouble(textBox_motion_x_speed.Text.ToString()));

                    if (!toggle_move.Checked)
                    {
                        pACS.m_pACSMotion[1].MoveABS(Convert.ToDouble(textBox_motion_x_input.Text.ToString()));
                    }

                    else
                        pACS.m_pACSMotion[1].MoveREL(Convert.ToDouble(textBox_motion_x_input.Text.ToString()));
                }
            }

            else if (button_motion_x_move.Text == "STOP")
            {
                pACS.m_pACSMotion[1].MoveStop();
            }
        }

        private void button_motion_y_move_Click(object sender, EventArgs e)
        {
            double dCommandPosY;

            dCommandPosY = Convert.ToDouble(textBox_motion_y_command.Text.ToString());

            if (button_motion_y_move.Text == "MOVE")
            {
                if (pACS.m_pACSMotion[2].dMinPos > dCommandPosY || pACS.m_pACSMotion[2].dMaxPos < dCommandPosY)
                {
                    MessageBox.Show("Y Axis Moving Position Error (Moving Range Over)", "ACSMotioen");
                }

                else
                {
                    pACS.m_pACSMotion[2].SetVelocity(Convert.ToDouble(textBox_motion_y_speed.Text.ToString()));

                    if (!toggle_move.Checked)
                        pACS.m_pACSMotion[2].MoveABS(Convert.ToDouble(textBox_motion_y_input.Text.ToString()));

                    else
                        pACS.m_pACSMotion[2].MoveREL(Convert.ToDouble(textBox_motion_y_input.Text.ToString()));
                }
            }

            else if (button_motion_y_move.Text == "STOP")
            {
                pACS.m_pACSMotion[2].MoveStop();
            }

        }

        private void button_motion_t_move_Click(object sender, EventArgs e)
        {
            double dCommandPosT;

            dCommandPosT = Convert.ToDouble(textBox_motion_t_command.Text.ToString());

            if (button_motion_t_move.Text == "MOVE")
            {
                if (pACS.m_pACSMotion[0].dMinPos > dCommandPosT || pACS.m_pACSMotion[0].dMaxPos < dCommandPosT)
                {
                    MessageBox.Show("Turn Moving Position Error (Moving Range Over)", "ACSMotioen");
                }

                else
                {
                    pACS.m_pACSMotion[0].SetVelocity(Convert.ToDouble(textBox_motion_t_speed.Text.ToString()));

                    if (!toggle_move.Checked)
                        pACS.m_pACSMotion[0].MoveABS(Convert.ToDouble(textBox_motion_t_input.Text.ToString()));

                    else
                        pACS.m_pACSMotion[0].MoveREL(Convert.ToDouble(textBox_motion_t_input.Text.ToString()));
                }
            }

            else if (button_motion_t_move.Text == "STOP")
            {
                pACS.m_pACSMotion[0].MoveStop();
            }
        }

        public void button_motion_preset_init()
        {
            button_motion_preset_1.BackColor = Color.White;
            button_motion_preset_2.BackColor = Color.White;
            button_motion_preset_3.BackColor = Color.White;
            button_motion_preset_4.BackColor = Color.White;
            button_motion_preset_5.BackColor = Color.White;
            button_motion_preset_6.BackColor = Color.White;
            button_motion_preset_7.BackColor = Color.White;
            button_motion_preset_8.BackColor = Color.White;
            button_motion_preset_laser.BackColor = Color.White;
            button_motion_preset_vision.BackColor = Color.White;
            button_motion_preset_depth.BackColor = Color.White;

            button_motion_preset_1.ForeColor = Color.Black;
            button_motion_preset_2.ForeColor = Color.Black;
            button_motion_preset_3.ForeColor = Color.Black;
            button_motion_preset_4.ForeColor = Color.Black;
            button_motion_preset_5.ForeColor = Color.Black;
            button_motion_preset_6.ForeColor = Color.Black;
            button_motion_preset_7.ForeColor = Color.Black;
            button_motion_preset_8.ForeColor = Color.Black;
            button_motion_preset_laser.ForeColor = Color.Black;
            button_motion_preset_vision.ForeColor = Color.Black;
            button_motion_preset_depth.ForeColor = Color.Black;

        }

        public void button_motion_preset_pos()
        {
            textBox_motion_preset_pos_x.Text = PresetConfig[nSelectedPreset].dPosX.ToString();
            textBox_motion_preset_pos_y.Text = PresetConfig[nSelectedPreset].dPosY.ToString();
            textBox_motion_preset_pos_t.Text = PresetConfig[nSelectedPreset].dPosT.ToString();
        }

        private void button_motion_preset_1_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 0;

            button_motion_preset_pos();
            button_motion_preset_1.BackColor = Color.Lime;
            button_motion_preset_1.ForeColor = Color.White;
        }

        private void button_motion_preset_2_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 1;

            button_motion_preset_pos();
            button_motion_preset_2.BackColor = Color.Lime;
            button_motion_preset_2.ForeColor = Color.White;
        }

        private void button_motion_preset_3_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 2;

            button_motion_preset_pos();
            button_motion_preset_3.BackColor = Color.Lime;
            button_motion_preset_3.ForeColor = Color.White;
        }

        private void button_motion_preset_4_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 3;

            button_motion_preset_pos();
            button_motion_preset_4.BackColor = Color.Lime;
            button_motion_preset_4.ForeColor = Color.White;
        }

        private void button_motion_preset_5_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 4;

            button_motion_preset_pos();
            button_motion_preset_5.BackColor = Color.Lime;
            button_motion_preset_5.ForeColor = Color.White;
        }

        private void button_motion_preset_6_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 5;

            button_motion_preset_pos();
            button_motion_preset_6.BackColor = Color.Lime;
            button_motion_preset_6.ForeColor = Color.White;
        }

        private void button_motion_preset_7_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 6;

            button_motion_preset_pos();
            button_motion_preset_7.BackColor = Color.Lime;
            button_motion_preset_7.ForeColor = Color.White;
        }

        private void button_motion_preset_8_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 7;

            button_motion_preset_pos();
            button_motion_preset_8.BackColor = Color.Lime;
            button_motion_preset_8.ForeColor = Color.White;
        }

        private void button_motion_preset_laser_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 8;

            button_motion_preset_pos();
            button_motion_preset_laser.BackColor = Color.Lime;
            button_motion_preset_laser.ForeColor = Color.White;
        }

        private void button_motion_preset_vision_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 9;

            button_motion_preset_pos();
            button_motion_preset_vision.BackColor = Color.Lime;
            button_motion_preset_vision.ForeColor = Color.White;

        }

        private void button_motion_preset_depth_Click(object sender, EventArgs e)
        {
            button_motion_preset_init();

            nSelectedPreset = 10;

            button_motion_preset_pos();
            button_motion_preset_depth.BackColor = Color.Lime;
            button_motion_preset_depth.ForeColor = Color.White;
        }

        private void button_motion_preset_set_current_Click(object sender, EventArgs e)
        {
            textBox_motion_preset_pos_x.Text = textBox_motion_x_actual.Text;
            textBox_motion_preset_pos_y.Text = textBox_motion_y_actual.Text;
            textBox_motion_preset_pos_t.Text = textBox_motion_t_actual.Text;
        }

        private void button_motion_preset_apply_Click(object sender, EventArgs e)
        {
            PresetConfig[nSelectedPreset].dPosX = Convert.ToDouble(textBox_motion_preset_pos_x.Text.ToString());
            PresetConfig[nSelectedPreset].dPosY = Convert.ToDouble(textBox_motion_preset_pos_y.Text.ToString());
            PresetConfig[nSelectedPreset].dPosT = Convert.ToDouble(textBox_motion_preset_pos_t.Text.ToString());
        }

        private void button_motion_preset_cancel_Click(object sender, EventArgs e)
        {
            readMotionPreset();
        }

        private void button_motion_preset_save_Click(object sender, EventArgs e)
        {
            String strFile = Application.StartupPath + @"\Config\MotionPreset.ini";
            string strTag;
            for (int i = 0; i < 10; i++)
            {
                strTag = "PRESET" + i.ToString();

                WritePrivateProfileString(strTag, "STAGE X", PresetConfig[i].dPosX.ToString(), strFile);
                WritePrivateProfileString(strTag, "STAGE Y", PresetConfig[i].dPosY.ToString(), strFile);
                WritePrivateProfileString(strTag, "TURN", PresetConfig[i].dPosT.ToString(), strFile);
            }
        }

        private void button_motion_preset_move_Click(object sender, EventArgs e)
        {
            string strPreset;

            strPreset = "Preset" + nSelectedPreset.ToString();

            if (nSelectedPreset == 8)
                strPreset = "Preset LASER";

            else if (nSelectedPreset == 9)
                strPreset = "Preset VISION";

            else if (nSelectedPreset == 10)
                strPreset = "Preset Depth";

            double dPresetPosX;
            double dPresetPosY;
            double dPresetPosT;

            dPresetPosX = Convert.ToDouble(textBox_motion_preset_pos_x.Text.ToString());
            dPresetPosY = Convert.ToDouble(textBox_motion_preset_pos_y.Text.ToString());
            dPresetPosT = Convert.ToDouble(textBox_motion_preset_pos_t.Text.ToString());


            if (pACS.m_pACSMotion[0].dMinPos > dPresetPosT || pACS.m_pACSMotion[0].dMaxPos < dPresetPosT
                || pACS.m_pACSMotion[1].dMinPos > dPresetPosX || pACS.m_pACSMotion[1].dMaxPos < dPresetPosX
                || pACS.m_pACSMotion[2].dMinPos > dPresetPosY || pACS.m_pACSMotion[2].dMaxPos < dPresetPosY)
            {
                MessageBox.Show("Moving Position Error (Moving Range Over)", "ACSMotioen");
            }

            else
            {
                if (MessageBox.Show(strPreset + "으로 이동하시겠습니까?", "ACSMotion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pACS.m_pACSMotion[0].SetVelocity(Convert.ToDouble(textBox_motion_t_speed.Text.ToString()));
                    pACS.m_pACSMotion[1].SetVelocity(Convert.ToDouble(textBox_motion_x_speed.Text.ToString()));
                    pACS.m_pACSMotion[2].SetVelocity(Convert.ToDouble(textBox_motion_y_speed.Text.ToString()));

                    bCheckPresetMoveX = false;
                    bCheckPresetMoveY = false;
                    bCheckPresetMoveT = true;
                }

                else
                {

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (statusThread != null)
            {
                statusThread.Abort();
                statusThread.Join();
            }

            if (atfThread != null)
            {
                atfThread.Abort();
                atfThread.Join();
            }

            if (processThread != null)
            {
                processThread.Abort();
                processThread.Join();
            }
        }

        private void textBox_motion_x_input_TextChanged(object sender, EventArgs e)
        {
            String strInput = textBox_motion_x_input.Text;

            if (double.TryParse(strInput, out dCommandX))
            {
                if (toggle_move.Checked)
                {
                    textBox_motion_x_command.Invoke(new EventHandler(delegate
                    { textBox_motion_x_command.Text = (dCommandX + Convert.ToDouble(textBox_motion_x_actual.Text)).ToString(); }));
                }

                else
                    textBox_motion_x_command.Invoke(new EventHandler(delegate
                    { textBox_motion_x_command.Text = dCommandX.ToString(); }));
            }

            else
            {
            }
        }

        private void textBox_motion_y_input_TextChanged(object sender, EventArgs e)
        {
            String strInput = textBox_motion_y_input.Text;

            if (double.TryParse(strInput, out dCommandY))
            {
                if (toggle_move.Checked)
                {
                    textBox_motion_y_command.Invoke(new EventHandler(delegate
                    { textBox_motion_y_command.Text = (dCommandY + Convert.ToDouble(textBox_motion_y_actual.Text)).ToString(); }));
                }

                else
                    textBox_motion_y_command.Invoke(new EventHandler(delegate
                    { textBox_motion_y_command.Text = dCommandY.ToString(); }));
            }

            else
            {
            }
        }

        private void textBox_motion_t_input_TextChanged(object sender, EventArgs e)
        {
            String strInput = textBox_motion_t_input.Text;

            if (double.TryParse(strInput, out dCommandT))
            {
                if (toggle_move.Checked)
                {
                    textBox_motion_t_command.Invoke(new EventHandler(delegate
                    { textBox_motion_t_command.Text = (dCommandT + Convert.ToDouble(textBox_motion_t_actual.Text)).ToString(); }));

                }

                else
                    textBox_motion_t_command.Invoke(new EventHandler(delegate
                    { textBox_motion_t_command.Text = dCommandT.ToString(); }));
            }

            else
            {
            }
        }

        private void button_wdi_connect_Click(object sender, EventArgs e)
        {
            ATF.ATF_OpenConnection("\\\\.\\COM2", 9600);

            atfThread = new Thread(new ThreadStart(ATFElapsed));
            atfThread.Start();
        }

        private void button_wdi_home_Click(object sender, EventArgs e)
        {
            int[] pHomingZ_Parameters = { };
            ATF.ATF_ReadHomingZ_Parameters(pHomingZ_Parameters);
            ATF.ATF_RunHomingZ(pHomingZ_Parameters);
        }

        private void textBox_wdi_pitch_TextChanged(object sender, EventArgs e)
        {
            string strInput = textBox_wdi_pitch.Text;
            if (double.TryParse(strInput, out dATFPitch))
            {
            }

            else
            {

            }
        }

        private void button_wdi_move_up_Click(object sender, EventArgs e)
        {
            int nValue = (int)(dATFPitch * 4);
            ATF.ATF_MoveZ(nValue);
        }

        private void button_wdi_move_down_Click(object sender, EventArgs e)
        {
            int nValue = (int)(dATFPitch * 4);
            ATF.ATF_MoveZ(-nValue);
        }

        private void button_wdi_move_stop_Click(object sender, EventArgs e)
        {
            ATF.ATF_StopZMotor();
        }

        private void button_wdi_set_low_Click(object sender, EventArgs e)
        {
            int nPosition = 0;
            ATF.ATF_ReadAbsZPos(out nPosition);
            double dPosition = (double)nPosition * 0.25;
            textBox_wdi_set_low.Text = dPosition.ToString("F2");
        }

        private void button_wdi_set_high_Click(object sender, EventArgs e)
        {
            int nPosition = 0;
            ATF.ATF_ReadAbsZPos(out nPosition);
            double dPosition = (double)nPosition * 0.25;
            textBox_wdi_set_high.Text = dPosition.ToString("F2");
        }

        private void textBox_wdi_step_TextChanged(object sender, EventArgs e)
        {
            string strInput = textBox_wdi_step.Text;

            if (double.TryParse(strInput, out dStep))
            {
            }

            else
            {
            }
        }

        private void comboBox_wdi_image_split_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_wdi_apply_Click(object sender, EventArgs e)
        {
            result_Graph_Init();
        }

        private void button_wdi_cancel_Click(object sender, EventArgs e)
        {

        }

        private void button_wdi_save_Click(object sender, EventArgs e)
        {

        }

        private void button_motion_stop_Click(object sender, EventArgs e)
        {
            // 긴급 정지
            pACS.m_pACSMotion[0].MoveStop();
            pACS.m_pACSMotion[1].MoveStop();
            pACS.m_pACSMotion[2].MoveStop();
        }

        private void button_vision_depth_connect_Click(object sender, EventArgs e)
        {
            InitMIL(panel_vision_depth_display.Handle);
        }

        public void InitMIL(IntPtr UserWindowHandle)
        {
            MIL.MappAlloc(MIL.M_NULL, MIL.M_DEFAULT, ref MilApplication);

            // Allocate a MIL system.
            MIL.MsysAlloc(MIL.M_DEFAULT, MIL.M_SYSTEM_SOLIOS, MIL.M_DEFAULT, MIL.M_DEFAULT, ref MilSystem);

            // Allocate a MIL display.
            MIL.MdispAlloc(MilSystem, MIL.M_DEFAULT, "M_DEFAULT", MIL.M_WINDOWED, ref MilDisplay);

            // Allocate a MIL digitizer, if supported, and set the target image size.
            if (MIL.MsysInquire(MilSystem, MIL.M_DIGITIZER_NUM, MIL.M_NULL) > 0)
            {
                //MIL.MdigAlloc(MilSystem, MIL.M_DEFAULT, "M_DEFAULT", MIL.M_DEFAULT, ref MilDigitizer);
                MIL.MdigAlloc(MilSystem, MIL.M_DEV0, MIL.M_SYSTEM_DEFAULT, MIL.M_DEFAULT, ref MilDigitizer);
                MIL.MdigInquire(MilDigitizer, MIL.M_SIZE_X, ref BufSizeX);
                MIL.MdigInquire(MilDigitizer, MIL.M_SIZE_Y, ref BufSizeY);
                MIL.MdigInquire(MilDigitizer, MIL.M_SIZE_BAND, ref BufSizeBand);
            }
            long Attributes = MIL.M_IMAGE + MIL.M_DISP;
            if (MilDigitizer != MIL.M_NULL)
            {
                // Add M_GRAB attribute if a digitizer is allocated.
                Attributes |= MIL.M_GRAB;
            }
            MIL.MbufAllocColor(MilSystem, BufSizeBand, BufSizeX, BufSizeY, 8 + MIL.M_UNSIGNED, Attributes, ref MilImage);

            // Clear the buffer.
            MIL.MbufClear(MilImage, 0);

            MIL.MdispZoom(MilDisplay, 0.125, 0.125);
            MIL.MdispSelectWindow(MilDisplay, MilImage, UserWindowHandle);
            MIL.MdigGrabContinuous(MilDigitizer, MilImage);
        }

        public void ImageSave(int nTurn)
        {
            string saveTitle = strTime + "\\" + nTurn.ToString() + ".bmp";

            MIL.MdigHalt(MilDigitizer);
            MIL.MdigGrab(MilDigitizer, MilImage);
            MIL.MdigGrabContinuous(MilDigitizer, MilImage);
            MIL.MbufExport(saveTitle, MIL.M_BMP, MilImage);
        }

        private double CalculateFocus(Rectangle rect, Bitmap image)
        {
            BitmapData bmpData = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);
            IntPtr ptr = bmpData.Scan0;

            int pixelSize = Bitmap.GetPixelFormatSize(image.PixelFormat) / 8; // 픽셀당 바이트 수
            byte[] pixelValues = new byte[pixelSize];

            int sum = 0;

            for (int x = 0; x < bmpData.Width; x++)
            {
                for (int y = 0; y < bmpData.Height; y++)
                {
                    System.Runtime.InteropServices.Marshal.Copy(ptr + (y * bmpData.Stride + x * pixelSize), pixelValues, 0, pixelSize);

                    if(pixelValues[0] > 60)
                        sum += pixelValues[0];
                }
            }
            double focus = (double)sum / (bmpData.Width * bmpData.Height);

            image.UnlockBits(bmpData);

            return focus;
        }

        private Bitmap BinaryImage(Bitmap image)
        {
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bitmapData = image.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            byte[] pixels = new byte[bitmapData.Width * bitmapData.Height];
            Marshal.Copy(bitmapData.Scan0, pixels, 0, pixels.Length);

            for (int y = 0; y < bitmapData.Height; y++)
            {
                for (int x = 0; x < bitmapData.Width; x++)
                {
                    byte pixel = pixels[y * bitmapData.Width + x];
                    if (pixel >= 100)
                    {
                        pixels[y * bitmapData.Width + x] = 255;
                    }
                    // 픽셀 값 사용
                }
            }
            Marshal.Copy(pixels, 0, bitmapData.Scan0, pixels.Length);

            image.UnlockBits(bitmapData);

            return image;
        }

        public Bitmap MorphologyOpen(Bitmap bmp, int size)
        {
            int nCount = 11;
            short[,] se = new short[nCount, nCount];

            for (int i = 0; i < nCount; i++)
            {
                for (int j = 0; j < nCount; j++)
                {
                    if (i == nCount / 2 || j == nCount / 2)
                        se[i, j] = 1;

                    else
                        se[i, j] = 0;
                }
            }

            // 구조 요소(structuring element) 생성
            //var se = new AForge.Imaging.Filters.CrossStructuringElement(size);

            // opening 필터 생성
            var opening = new Opening(se);

            // opening 필터 적용
            return opening.Apply(bmp);
        }

        // Close 연산
        public Bitmap MorphologyClose(Bitmap bmp, int size)
        {
            //            short[,] se = new short[,]
            //{
            //                { 0, 1, 0 },
            //                { 1, 1, 1 },
            //                { 0, 1, 0 }
            //};
            int nCount = 3;
            short[,] se = new short[nCount, nCount];

            for (int i = 0; i < nCount; i++)
            {
                for (int j = 0; j < nCount; j++)
                {
                    if (i == nCount / 2 || j == nCount / 2)
                        se[i, j] = 1;

                    else
                        se[i, j] = 0;
                }
            }

            //            short[,] se = new short[,]
            //{
            //                { 0, 0, 1, 0,0 },
            //                { 0, 0, 1, 0,0 },
            //                { 1, 1, 1, 1,1 },
            //                { 0, 0, 1, 0,0 },
            //                { 0, 0, 1, 0,0 }
            //};

            // 구조 요소(structuring element) 생성
            //var se = new AForge.Imaging.Filters.CrossStructuringElement(size);

            // closing 필터 생성
            var closing = new Closing(se);

            // closing 필터 적용
            return closing.Apply(bmp);
        }

        public void ImageAnalysis(int nGrabCount)
        {
            string loadTitle;
            int nCount = nGrabCount;

            ResultConfig[nCount].dAVGValue = new double[(2048 / nImageSplit) * (2048 / nImageSplit)];

            //if (textBox_number.Text == "1")
            //    loadTitle = strData + "\\1_1\\" + nCount.ToString() + ".bmp";

            //else if (textBox_number.Text == "2")
            //    loadTitle = strData + "\\1_2\\" + nCount.ToString() + ".bmp";

            //else
            //    loadTitle = strData + "\\1_3\\" + nCount.ToString() + ".bmp";


            //            loadTitle = strData + "\\0.25_3\\" + nCount.ToString() + ".bmp";
            loadTitle = strTime + "\\" + nCount.ToString() + ".bmp";
            Bitmap bmpImg = new Bitmap(loadTitle);
            ImageConfig[nCount].bmpImg = bmpImg;

            int width = bmpImg.Width;
            int height = bmpImg.Height;

            // 이미지를 저장하고,
            // 해당 이미지에서 이진화 알고리즘을 적용해서
            // 특정 값보다 높은 픽셀을 다 동일한 값으로 변경해버리자.

            //Bitmap binary = BinaryImage(bmpImg);

            Bitmap blur = new GaussianBlur().Apply(bmpImg);

            SobelEdgeDetector sobelEdgeDetector = new SobelEdgeDetector();
            Bitmap edges = sobelEdgeDetector.Apply(blur);

            Bitmap open = MorphologyOpen(edges, 3);
            Bitmap close = MorphologyClose(edges, 3);

            //Bitmap open = MorphologyOpen(close, 3);

            string strOpenPath;
            string strClosePath;

            strOpenPath = strTime + "\\Open" + nCount.ToString() + ".bmp";
            strClosePath = strTime + "\\Close" + nCount.ToString() + ".bmp";
            open.Save(strOpenPath);
            close.Save(strClosePath);

            int[,] kernel = new int[,]
            {
    {-1,-1,-1},
    {-1, 8,-1},
    {-1,-1,-1},
            };
            Convolution laplacianFilter = new Convolution(kernel);

            // 라플라시안 필터 적용하여 처리된 이미지 생성
            Bitmap laplacianImage = laplacianFilter.Apply(open);

            string strVOLPath;

            strVOLPath = strTime + "\\VOL" + nCount.ToString() + ".bmp";
            laplacianImage.Save(strVOLPath);

            // 이미지의 각 픽셀의 gradient 값들의 분산을 계산합니다.
            //double variance = 0.0;
            //for (int x = 0; x < laplacianImage.Width; x++)
            //{
            //    for (int y = 0; y < laplacianImage.Height; y++)
            //    {
            //        // 현재 픽셀의 gradient 값을 가져옵니다.
            //        byte gradient = laplacianImage.GetPixel(x, y).R;

            //        // 분산 계산을 위해 gradient 값을 double 형으로 변환합니다.
            //        double gradientDouble = (double)gradient;

            //        // 분산을 계산합니다.
            //        variance += gradientDouble * gradientDouble;
            //    }
            //}
            //variance /= laplacianImage.Width * laplacianImage.Height;

            //// 계산된 분산을 출력합니다.
            //Console.WriteLine($"Variance of Laplacian: {variance}");


            //



            string strEdgePath;
            strEdgePath = strTime + "\\Edge" + nCount.ToString() + ".bmp";

            edges.Save(strEdgePath);
            nAnalysisCount = 0;
            int nXStart = 0;
            int nYStart = 0;

            for (int yTotal = 0; yTotal < height - nImageSplit + 1; yTotal += nImageSplit)
            {
                for (int xTotal = 0; xTotal < width - nImageSplit + 1; xTotal += nImageSplit)
                {
                    double focus = CalculateFocus(new Rectangle(nXStart, nYStart, nImageSplit, nImageSplit), open);

                    nXStart += nImageSplit;

                    if (nXStart >= 2048)
                    {
                        nXStart = 0;
                        nYStart += nImageSplit;
                    }

                    if (nYStart >= 2048)
                        nYStart = 0;

                    ResultConfig[nCount].dAVGValue[nAnalysisCount] = focus;
                    nAnalysisCount++;
                }
            }
        }

        public static Bitmap ApplyGaussianBlur(Bitmap sourceImage, int blurRadius)
        {
            Bitmap blurredImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // LockBits 메서드를 사용하여 BitmapData 객체를 가져옵니다.
            BitmapData sourceData = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData blurredData = blurredImage.LockBits(new Rectangle(0, 0, blurredImage.Width, blurredImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            // BitmapData 객체에서 바이트 배열을 가져옵니다.
            byte[] sourceBytes = new byte[sourceData.Stride * sourceData.Height];
            byte[] blurredBytes = new byte[blurredData.Stride * blurredData.Height];
            Marshal.Copy(sourceData.Scan0, sourceBytes, 0, sourceBytes.Length);
            Marshal.Copy(blurredData.Scan0, blurredBytes, 0, blurredBytes.Length);

            // Gaussian blur 필터를 만듭니다.
            double[,] kernel = CreateGaussianKernel(blurRadius);
            int kernelSize = kernel.GetLength(0);
            int radius = (kernelSize - 1) / 2;

            // BitmapData 객체의 각 픽셀을 처리합니다.
            for (int y = radius; y < sourceData.Height - radius; y++)
            {
                for (int x = radius; x < sourceData.Width - radius; x++)
                {
                    double blue = 0, green = 0, red = 0;

                    // Gaussian blur 필터를 적용합니다.
                    for (int ky = -radius; ky <= radius; ky++)
                    {
                        for (int kx = -radius; kx <= radius; kx++)
                        {
                            int index = (y + ky) * sourceData.Stride + (x + kx) * 4;
                            blue += sourceBytes[index] * kernel[ky + radius, kx + radius];
                            green += sourceBytes[index + 1] * kernel[ky + radius, kx + radius];
                            red += sourceBytes[index + 2] * kernel[ky + radius, kx + radius];
                        }
                    }

                    int indexOut = y * blurredData.Stride + x * 4;
                    blurredBytes[indexOut] = (byte)blue;
                    blurredBytes[indexOut + 1] = (byte)green;
                    blurredBytes[indexOut + 2] = (byte)red;
                    blurredBytes[indexOut + 3] = 255;
                }
            }

            // 바이트 배열을 BitmapData 객체에 복사합니다.
            Marshal.Copy(blurredBytes, 0, blurredData.Scan0, blurredBytes.Length);
            sourceImage.UnlockBits(sourceData);
            blurredImage.UnlockBits(blurredData);

            return blurredImage;
        }

        private static double[,] CreateGaussianKernel(int radius)
        {
            int kernelSize = 2 * radius + 1;
            double[,] kernel = new double[kernelSize, kernelSize];
            double sigma = radius / 3.0;

            double sum = 0;
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double value = Math.Exp(-(x * x + y * y) / (2 * sigma * sigma));
                    kernel[y + radius, x + radius] = value;
                    sum += value;
                }
            }

            // 모든 원소의 합이 1이 되도록 정규화합니다.
            for (int y = 0; y < kernelSize; y++)
            {
                for (int x = 0; x < kernelSize; x++)
                {
                    kernel[y, x] /= sum;
                }
            }

            return kernel;
        }


        public void ResultAnalysis()
        {
            dResultBest = new int[((2048 / nImageSplit)) * ((2048 / nImageSplit))];
            dResultBestValue = new double[((2048 / nImageSplit)) * ((2048 / nImageSplit))];
            dResultBestPosition = new double[((2048 / nImageSplit)) * ((2048 / nImageSplit))];

            for (int i = 0; i < nStepCount; i++)
            {
                for (int j = 0; j < nAnalysisCount; j++)
                {
                    if (ResultConfig[i].dAVGValue[j] > dResultBestValue[j])
                    {
                        double dBestValue = ResultConfig[i].dAVGValue[j];
                        dResultBestValue[j] = ResultConfig[i].dAVGValue[j];
                        dResultBest[j] = i;
                    }
                }
            }

            for (int i = 0; i < ((2048 / nImageSplit) * (2048 / nImageSplit)); i++)
            {
                dResultBestPosition[i] = dResultBest[i] * dStep;
            }
            // 노이즈 제거 방법 강구 필요
            // x축 노이즈 제거
            //for (int i = 0; i < nAnalysisCount - 1; i++)
            //{
            //    if (i > 0)
            //    {
            //        int mm = i % (2048 / nImageSplit);

            //        if (0 == i % (2048 / nImageSplit))
            //        {
            //            int m = 0;
            //            continue;
            //        }
            //    }

            //    if (Math.Abs((dResultBest[i + 1] - dResultBest[i])) > 5)
            //    {
            //        dResultBest[i + 1] = dResultBest[i];
            //    }
            //}

            //// y축 노이즈 제거
            //for (int i = 0; i < nAnalysisCount - (2048 / nImageSplit); i++)
            //{
            //    if (Math.Abs((dResultBest[i + (2048 / nImageSplit)] - dResultBest[i])) > 5)
            //    {
            //        dResultBest[i + (2048 / nImageSplit)] = dResultBest[i];
            //    }
            //}


            int nMaxValue = ((2048 / nImageSplit)) * ((2048 / nImageSplit));

            int xdata = 0;
            int ydata = 0;

            heightData = new double[2048 / nImageSplit, 2048 / nImageSplit];

            for (int i = 0; i < nMaxValue; i++)
            {
                heightData[xdata, ydata] = (double)dResultBest[i] / nStepCount;
                xdata++;
                if (xdata >= 2048 / nImageSplit)
                {
                    xdata = 0;
                    ydata++;
                }
            }
        }

        public void ImageMappingColor()
        {
            Bitmap Color = new Bitmap(2048, 2048);

            int nXPos = 0;
            int nYPos = 0;

            for (int i = 0; i < nAnalysisCount; i++)
            {
                int nValue = dResultBest[i] * (255 / nStepCount);
                //int nValue = dResultBest[i];// * (255 / nStepCount);

                if (i % (2048 / nImageSplit) == 0 && i != 0)
                {
                    nXPos = 0;
                    nYPos += nImageSplit;
                }

                for (int j = 0; j < nImageSplit; j++)
                {
                    for (int k = 0; k < nImageSplit; k++)
                    {
                        //Color.SetPixel(nXPos, nYPos + k, System.Drawing.Color.FromArgb(255, nValue, nValue, nValue));//colors[nValue]);
                        Color.SetPixel(nXPos, nYPos + k, colors[nValue]);

                    }
                    nXPos++;
                }
            }

            string strColor;
            strColor = strTime + "\\" + "color.bmp";
            Color.Save(strColor);
            BmpColor = new Bitmap(Color);

            pictureBox_vision_color.Invoke(new EventHandler(delegate
            { pictureBox_vision_color.Image = Color; }));

            //pictureBox_vision_color.Image = Color;
            //pictureBox_vision_color.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox_vision_color.Invoke(new EventHandler(delegate
            { pictureBox_vision_color.Refresh(); }));
        }

        public void ImageMappingMerge()
        {
            Bitmap result = new Bitmap(2048, 2048);

            // Graphics 객체 생성
            using (Graphics g = Graphics.FromImage(result))
            {
                int x = 0;
                int y = 0;

                int nCount = ((2048 / nImageSplit)) * ((2048 / nImageSplit));

                for (int i = 0; i < nCount; i++)
                {
                    int nBest = dResultBest[i];

                    Rectangle rect = new Rectangle(x, y, nImageSplit, nImageSplit);
                    g.DrawImage(ImageConfig[nBest].bmpImg.Clone(new Rectangle(x, y, nImageSplit, nImageSplit), System.Drawing.Imaging.PixelFormat.DontCare), rect);

                    x += nImageSplit;
                    if (x >= 2048)
                    {
                        x = 0;
                        y += nImageSplit;
                    }
                }
            }

            string strMerge;
            strMerge = strTime + "\\" + "merge.bmp";
            result.Save(strMerge);

            BmpMerge = new Bitmap(result);

            pictureBox_vision_merge.Invoke(new EventHandler(delegate
            { pictureBox_vision_merge.Image = result; }));

            //pictureBox_vision_merge.Image = result;
            //pictureBox_vision_merge.SizeMode = PictureBoxSizeMode.Zoom;

            //pictureBox_vision_merge.Refresh();
            pictureBox_vision_merge.Invoke(new EventHandler(delegate
            { pictureBox_vision_merge.Refresh(); }));

        }

        public void depth_display_pos(int nCase)
        {
            // merge main
            if (nCase == 0)
            {
                pictureBox_vision_merge.Image = BmpMerge;
                pictureBox_vision_color.Image = BmpColor;

                pictureBox_colormap.Image = null;
                pictureBox_colormap_2.Image = BmpColorMap;
            }

            // color main
            else if (nCase == 1)
            {
                pictureBox_vision_merge.Image = BmpColor;
                pictureBox_vision_color.Image = BmpMerge;

                pictureBox_colormap.Image = BmpColorMap;
                pictureBox_colormap_2.Image = null;
            }

            // 3d main
            else if (nCase == 2)
            {
            }
        }

        public void result_Graph_Init()
        {
            chart_result.Series.Clear();

            Series series1 = new Series();
            series1.Name = "Depth Data";
            series1.ChartType = SeriesChartType.Spline;
            series1.YAxisType = AxisType.Secondary;
            chart_result.Series.Add(series1);

            chart_result.Series["Depth Data"].IsVisibleInLegend = false;

            chart_result.ChartAreas[0].InnerPlotPosition.Auto = false; // InnerPlotPosition 속성을 수동으로 설정
            chart_result.ChartAreas[0].InnerPlotPosition.Width = 89; // InnerPlotPosition의 폭을 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.Height = 90;// InnerPlotPosition의 높이를 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.X = 5; // InnerPlotPosition의 X 위치를 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.Y = 5;

            chart_result.ChartAreas[0].Position.Auto = false; // Position 속성을 수동으로 설정
            chart_result.ChartAreas[0].Position.Width = 90; // Position의 폭을 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.Height = 90; // Position의 높이를 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.X = 0; // Position의 X 위치를 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.Y = 0; // Position의 Y 위치를 설정 (단위 : %)

            chart_result.ChartAreas[0].AxisX.Minimum = 0.0;
            chart_result.ChartAreas[0].AxisX.Maximum = 110.0;

            chart_result.ChartAreas[0].AxisY2.Minimum = -Convert.ToDouble(textBox_wdi_step.Text.ToString());
            chart_result.ChartAreas[0].AxisY2.Maximum = (Convert.ToDouble(textBox_wdi_set_high.Text.ToString()) - Convert.ToDouble(textBox_wdi_set_low.Text.ToString()))
                + (Convert.ToDouble(textBox_wdi_step.Text.ToString()) * 2);    // Y축 최대값

            for (int x = 0; x < 150; x++)
            {
                chart_result.Series[0].Points.AddXY(x, -0.5);
            }

        }

        public void result_graph()
        {
            chart_result.Series.Clear();
            double Xdata = 0.0f;
            double Ydata = 0.0f;

            Series series1 = new Series();
            series1.Name = "Depth Data";
            series1.ChartType = SeriesChartType.Spline;
            series1.YAxisType = AxisType.Secondary;

            chart_result.Series.Add(series1);

            chart_result.Series["Depth Data"].IsVisibleInLegend = false;

            chart_result.ChartAreas[0].InnerPlotPosition.Auto = false; // InnerPlotPosition 속성을 수동으로 설정
            chart_result.ChartAreas[0].InnerPlotPosition.Width = 89; // InnerPlotPosition의 폭을 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.Height = 90;// InnerPlotPosition의 높이를 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.X = 5; // InnerPlotPosition의 X 위치를 설정 (단위 : %)
            chart_result.ChartAreas[0].InnerPlotPosition.Y = 5;

            chart_result.ChartAreas[0].Position.Auto = false; // Position 속성을 수동으로 설정
            chart_result.ChartAreas[0].Position.Width = 90; // Position의 폭을 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.Height = 90; // Position의 높이를 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.X = 0; // Position의 X 위치를 설정 (단위 : %)
            chart_result.ChartAreas[0].Position.Y = 0; // Position의 Y 위치를 설정 (단위 : %)

            chart_result.ChartAreas[0].AxisX.Minimum = 0.0;     // X축 최소값
            chart_result.ChartAreas[0].AxisX.Maximum = 110.0;    // X축 최대값

            chart_result.ChartAreas[0].AxisY2.Minimum = -Convert.ToDouble(textBox_wdi_step.Text.ToString());
            chart_result.ChartAreas[0].AxisY2.Maximum = (Convert.ToDouble(textBox_wdi_set_high.Text.ToString()) - Convert.ToDouble(textBox_wdi_set_low.Text.ToString()))
                + (Convert.ToDouble(textBox_wdi_step.Text.ToString()) * 2);    // Y축 최대값

            int nCount = 2048 / nImageSplit;

            Xdata = Math.Round(((double)(pFirstPoint.X * 4) / nImageSplit * (0.055 * nImageSplit)));

            dIntercept = (int)(dIntercept * 4 / nImageSplit);
            double nStartX = Math.Round((((double)pFirstPoint.X * 4) / nImageSplit));
            double nEndX = Math.Round((((double)pSecondPoint.X * 4) / nImageSplit));

            for (int i = (int)nStartX; i < nEndX; i++)
            {
                int yD = (int)(((i * dGradient) + dIntercept));

                Ydata = dResultBestPosition[(yD * nCount) + i];

                chart_result.Series[0].Points.AddXY(Xdata, Ydata);

                Xdata += (0.055 * nImageSplit);
            }
        }

        private void chart_result_MouseClick(object sender, MouseEventArgs e)
        {
            Series seriesPoint = chart_result.Series["Depth Data"];
            MouseEventArgs me = (MouseEventArgs)e;
            System.Drawing.Point coordinates = me.Location;

            double dXValue = 0.0;
            double dYValue = 0.0;

            if (!bCheckMoveLeft1 && bMouseInLeft1 && !bCheckMoveLeft2 && !bCheckMoveLeft3 && !bCheckMoveRight1 && !bCheckMoveRight2 && !bCheckMoveRight3)
                bCheckMoveLeft1 = true;

            else if (bCheckMoveLeft1 && bMouseInLeft1)
            {
                bCheckMoveLeft1 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXFirst_1 = dXValue;
                bCheckConfirmLeft1 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft1 && bCheckConfirmRight1)
                {
                    textBox_measure_width_1.Text = Math.Abs((dXSecond_1 - dXFirst_1)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveLeft2 && bMouseInLeft2 && !bCheckMoveLeft3 && !bCheckMoveRight1 && !bCheckMoveRight2 && !bCheckMoveRight3)
                bCheckMoveLeft2 = true;

            else if (bCheckMoveLeft2 && bMouseInLeft2)
            {
                bCheckMoveLeft2 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXFirst_2 = dXValue;
                bCheckConfirmLeft2 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft2 && bCheckConfirmRight2)
                {
                    textBox_measure_width_2.Text = Math.Abs((dXSecond_2 - dXFirst_2)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveLeft3 && bMouseInLeft3 && !bCheckMoveRight1 && !bCheckMoveRight2 && !bCheckMoveRight3)
                bCheckMoveLeft3 = true;

            else if (bCheckMoveLeft3 && bMouseInLeft3)
            {
                bCheckMoveLeft3 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXFirst_3 = dXValue;
                bCheckConfirmLeft3 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft3 && bCheckConfirmRight3)
                {
                    textBox_measure_width_3.Text = Math.Abs((dXSecond_3 - dXFirst_3)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveRight1 && bMouseInRight1 && !bCheckMoveRight2 && !bCheckMoveRight3 && !bCheckMoveLeft1 && !bCheckMoveLeft2 && !bCheckMoveLeft3)
                bCheckMoveRight1 = true;

            else if (bCheckMoveRight1 && bMouseInRight1)
            {
                bCheckMoveRight1 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXSecond_1 = dXValue;
                bCheckConfirmRight1 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft1 && bCheckConfirmRight1)
                {
                    textBox_measure_width_1.Text = Math.Abs((dXSecond_1 - dXFirst_1)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveRight2 && bMouseInRight2 && !bCheckMoveRight3 && !bCheckMoveLeft1 && !bCheckMoveLeft2 && !bCheckMoveLeft3)
                bCheckMoveRight2 = true;

            else if (bCheckMoveRight2 && bMouseInRight2)
            {
                bCheckMoveRight2 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXSecond_2 = dXValue;
                bCheckConfirmRight2 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft2 && bCheckConfirmRight2)
                {
                    textBox_measure_width_2.Text = Math.Abs((dXSecond_2 - dXFirst_2)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveRight3 && bMouseInRight3 && !bCheckMoveLeft1 && !bCheckMoveLeft2 && !bCheckMoveLeft3)
                bCheckMoveRight3 = true;

            else if (bCheckMoveRight3 && bMouseInRight3)
            {
                bCheckMoveRight3 = false;

                double dMin = chart_result.ChartAreas[0].AxisX.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisX.Maximum;

                double dArea = dMax - dMin;

                dXValue = ((double)(coordinates.X - 28) / 102) * 22;
                dXSecond_3 = dXValue;
                bCheckConfirmRight3 = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmLeft3 && bCheckConfirmRight3)
                {
                    textBox_measure_width_3.Text = Math.Abs((dXSecond_3 - dXFirst_3)).ToString("F2") + "㎛";
                }
            }

            else if (!bCheckMoveTop && bMouseInTop)
                bCheckMoveTop = true;

            else if (bCheckMoveTop && bMouseInTop)
            {
                bCheckMoveTop = false;

                double dMin = chart_result.ChartAreas[0].AxisY2.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisY2.Maximum;

                double dArea = dMax - dMin;
                dYValue = (254 - coordinates.Y) * (dArea / 240);

                dYFirst = dYValue;

                bCheckConfirmTop = true;
                pictureBox_vision_merge.Invalidate();

                if (bCheckConfirmTop && bCheckConfirmBottom)
                {
                    textBox_measure_height.Text = Math.Abs((dYSecond - dYFirst)).ToString("F2") + "㎛";

                }
            }

            else if (!bCheckMoveBottom && bMouseInBottom)
                bCheckMoveBottom = true;

            else if (bCheckMoveBottom && bMouseInBottom)
            {
                bCheckMoveBottom = false;

                double dMin = chart_result.ChartAreas[0].AxisY2.Minimum;
                double dMax = chart_result.ChartAreas[0].AxisY2.Maximum;

                double dArea = dMax - dMin;

                dYValue = (254 - coordinates.Y) * (dArea / 240);

                dYSecond = dYValue;
                bCheckConfirmBottom = true;

                if (bCheckConfirmTop && bCheckConfirmBottom)
                {
                    textBox_measure_height.Text = Math.Abs((dYSecond - dYFirst)).ToString("F2") + "㎛";
                }
            }
        }

        private void chart_result_MouseMove(object sender, MouseEventArgs e)
        {
            if (bCheckClick)
            {
                CheckMousePositionLeft1(LeftRectX1, new System.Drawing.Point(e.X, e.Y));
                CheckMousePositionLeft2(LeftRectX2, new System.Drawing.Point(e.X, e.Y));
                CheckMousePositionLeft3(LeftRectX3, new System.Drawing.Point(e.X, e.Y));

                CheckMousePositionRight1(RightRectX1, new System.Drawing.Point(e.X, e.Y));
                CheckMousePositionRight2(RightRectX2, new System.Drawing.Point(e.X, e.Y));
                CheckMousePositionRight3(RightRectX3, new System.Drawing.Point(e.X, e.Y));

                CheckMousePositionHorizontal1(TopRectY, new System.Drawing.Point(e.X, e.Y));
                CheckMousePositionHorizontal2(BottomRectY, new System.Drawing.Point(e.X, e.Y));

                ChangeCursor();

                // 좌측 선
                if (bCheckMoveLeft1)
                {
                    LeftRectX1.X = e.X;
                    MergeLeftRectX1.X = e.X - 31;
                    chart_result.Invalidate();
                }

                else if (bCheckMoveLeft2)
                {
                    LeftRectX2.X = e.X;
                    MergeLeftRectX2.X = e.X - 31;
                    chart_result.Invalidate();
                }

                else if (bCheckMoveLeft3)
                {
                    LeftRectX3.X = e.X;
                    MergeLeftRectX3.X = e.X - 31;
                    chart_result.Invalidate();
                }

                // 우측 선
                else if (bCheckMoveRight1)
                {
                    RightRectX1.X = e.X;
                    MergeRightRectX1.X = e.X - 31;
                    chart_result.Invalidate();
                }

                else if (bCheckMoveRight2)
                {
                    RightRectX2.X = e.X;
                    MergeRightRectX2.X = e.X - 31;
                    chart_result.Invalidate();
                }

                else if (bCheckMoveRight3)
                {
                    RightRectX3.X = e.X;
                    MergeRightRectX3.X = e.X - 31;
                    chart_result.Invalidate();
                }

                // 상부 선
                else if (bCheckMoveTop)
                {
                    TopRectY.Y = e.Y;
                    chart_result.Invalidate();
                }

                // 하부 선
                else if (bCheckMoveBottom)
                {
                    BottomRectY.Y = e.Y;
                    chart_result.Invalidate();
                }
            }
        }

        private void chart_result_PostPaint(object sender, ChartPaintEventArgs e)
        {
            if (bCheckClick)
            {
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Red, LeftRectX1);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Orange, LeftRectX2);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Blue, LeftRectX3);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Red, RightRectX1);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Orange, RightRectX2);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Blue, RightRectX3);

                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Green, TopRectY);
                e.ChartGraphics.Graphics.FillRectangle(System.Drawing.Brushes.Green, BottomRectY);
            }
        }

        private void pictureBox_vision_merge_MouseDown(object sender, MouseEventArgs e)
        {
            if (bCheckClick)
            {
                if (nClickCount == 0)
                {
                    pFirstPoint = new System.Drawing.Point(e.X, e.Y);
                    pSecondPoint = new System.Drawing.Point(e.X, e.Y);
                    nClickCount++;
                }

                else if (nClickCount == 1)
                {
                    if ((ModifierKeys & Keys.Shift) == Keys.Shift)
                    {
                        pSecondPoint.X = e.X;
                        pSecondPoint.Y = pFirstPoint.Y;
                    }

                    else
                    {
                        pSecondPoint = new System.Drawing.Point(e.X, e.Y);
                    }

                    nClickCount = 0;

                    pictureBox_vision_merge.Refresh();

                    double dx;
                    double dy;

                    dx = pSecondPoint.X - pFirstPoint.X;
                    dy = pSecondPoint.Y - pFirstPoint.Y;

                    dGradient = dy / dx;

                    try
                    {
                        dIntercept = (pSecondPoint.X * pFirstPoint.Y - pFirstPoint.X * pSecondPoint.Y) / (pSecondPoint.X - pFirstPoint.X);
                        result_graph();
                    }
                    catch
                    {
                        MessageBox.Show("기울기 재설정 요망");
                    }
                }
            }
        }

        private void pictureBox_vision_merge_MouseMove(object sender, MouseEventArgs e)
        {
            if (bCheckClick)
            {
                if (nClickCount == 1)
                {
                    if ((ModifierKeys & Keys.Shift) == Keys.Shift)
                    {
                        pSecondPoint.X = e.X;
                        pSecondPoint.Y = pFirstPoint.Y;
                        pictureBox_vision_merge.Refresh();
                    }

                    else
                    {
                        pSecondPoint = new System.Drawing.Point(e.X, e.Y);
                        pictureBox_vision_merge.Refresh();
                    }
                }
            }

        }

        private void pictureBox_vision_merge_Paint(object sender, PaintEventArgs e)
        {
            if (bCheckClick)
            {
                using (System.Drawing.Pen penRed = new System.Drawing.Pen(System.Drawing.Color.Red, 1))
                {
                    e.Graphics.DrawLine(penRed, pFirstPoint, pSecondPoint);

                    e.Graphics.FillRectangle(System.Drawing.Brushes.Red, MergeLeftRectX1);
                    e.Graphics.FillRectangle(System.Drawing.Brushes.Red, MergeRightRectX1);

                    e.Graphics.FillRectangle(System.Drawing.Brushes.Orange, MergeLeftRectX2);
                    e.Graphics.FillRectangle(System.Drawing.Brushes.Orange, MergeRightRectX2);

                    e.Graphics.FillRectangle(System.Drawing.Brushes.Blue, MergeLeftRectX3);
                    e.Graphics.FillRectangle(System.Drawing.Brushes.Blue, MergeRightRectX3);
                }
            }
        }

        public void CheckMousePositionLeft1(Rectangle r, System.Drawing.Point e)
        {
            bMouseInLeft1 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionLeft2(Rectangle r, System.Drawing.Point e)
        {
            bMouseInLeft2 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionLeft3(Rectangle r, System.Drawing.Point e)
        {
            bMouseInLeft3 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionRight1(Rectangle r, System.Drawing.Point e)
        {
            bMouseInRight1 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionRight2(Rectangle r, System.Drawing.Point e)
        {
            bMouseInRight2 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionRight3(Rectangle r, System.Drawing.Point e)
        {
            bMouseInRight3 = (Math.Abs(e.X - r.X) <= 3);
        }

        public void CheckMousePositionHorizontal1(Rectangle r, System.Drawing.Point e)
        {
            bMouseInTop = (Math.Abs(e.Y - r.Y) <= 3);
        }

        public void CheckMousePositionHorizontal2(Rectangle r, System.Drawing.Point e)
        {
            bMouseInBottom = (Math.Abs(e.Y - r.Y) <= 3);
        }

        public void ChangeCursor()
        {
            if (bMouseInLeft1 || bMouseInLeft2 || bMouseInLeft3 || bMouseInRight1 || bMouseInRight2 || bMouseInRight3)
            {
                chart_result.Cursor = Cursors.VSplit;
            }

            else if (bMouseInTop || bMouseInBottom)
                chart_result.Cursor = Cursors.HSplit;

            else
                chart_result.Cursor = Cursors.Default;
        }

        private void button_depth_measure_Click(object sender, EventArgs e)
        {
            if (!bCheckClick)
            {
                bCheckClick = true;
                button_depth_measure.BackColor = Color.Lime;
                button_depth_measure.ForeColor = Color.White;
            }

            else
            {
                bCheckClick = false;
                button_depth_measure.BackColor = Color.White;
                button_depth_measure.ForeColor = Color.Black;
                result_Graph_Init();

                pFirstPoint.X = 0;
                pFirstPoint.Y = 0;
                pSecondPoint.X = 0;
                pSecondPoint.Y = 0;
            }

            chart_result.Invalidate();
            pictureBox_vision_merge.Invalidate();

            MergeLeftRectX1 = new Rectangle(0, 0, 1, 512);
            MergeRightRectX1 = new Rectangle(512, 0, 1, 512);
            MergeLeftRectX2 = new Rectangle(0, 0, 1, 512);
            MergeRightRectX2 = new Rectangle(512, 0, 1, 512);
            MergeLeftRectX3 = new Rectangle(0, 0, 1, 512);
            MergeRightRectX3 = new Rectangle(512, 0, 1, 512);

            LeftRectX1 = new Rectangle(30, 14, 1, 240);
            RightRectX1 = new Rectangle(540, 14, 1, 240);
            LeftRectX2 = new Rectangle(30, 14, 1, 240);
            RightRectX2 = new Rectangle(540, 14, 1, 240);
            LeftRectX3 = new Rectangle(30, 14, 1, 240);
            RightRectX3 = new Rectangle(540, 14, 1, 240);

            TopRectY = new Rectangle(30, 14, 510, 1);
            BottomRectY = new Rectangle(30, 254, 510, 1);

            textBox_measure_width_1.Text = "";
            textBox_measure_width_2.Text = "";
            textBox_measure_width_3.Text = "";
            textBox_measure_height.Text = "";
        }

        private void button_display_change_Click(object sender, EventArgs e)
        {
            if (nSelectedDisplay == 0)
                nSelectedDisplay = 1;

            else if (nSelectedDisplay == 1)
                nSelectedDisplay = 0;

            depth_display_pos(nSelectedDisplay);
        }
    }
}
