namespace ACSMotion
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel_motion = new System.Windows.Forms.Panel();
            this.panel_motion_cycle = new System.Windows.Forms.Panel();
            this.button_motion_cycle_move = new System.Windows.Forms.Button();
            this.label_motion_cycle_step_method_num = new System.Windows.Forms.Label();
            this.textBox_motion_cycle_step_num = new System.Windows.Forms.TextBox();
            this.label_motion_cycle_step_num = new System.Windows.Forms.Label();
            this.label_motion_cycle_step_method_stroke = new System.Windows.Forms.Label();
            this.textBox_motion_cycle_step_delay = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_step_max_stroke = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_step_speed = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_step = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_move_delay = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_move_speed = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_move = new System.Windows.Forms.TextBox();
            this.label_motion_cycle_axis_y = new System.Windows.Forms.Label();
            this.label_motion_cycle_axis_x = new System.Windows.Forms.Label();
            this.textBox_motion_cycle_start_y = new System.Windows.Forms.TextBox();
            this.textBox_motion_cycle_start_x = new System.Windows.Forms.TextBox();
            this.label_motion_cycle_step_max_stroke = new System.Windows.Forms.Label();
            this.toggle_motion_cycle_step_method = new ACSMotion.Control.ToggleButton();
            this.label_motion_cycle_step_delay = new System.Windows.Forms.Label();
            this.label_motion_cycle_move_delay = new System.Windows.Forms.Label();
            this.label_motion_cycle_step_speed = new System.Windows.Forms.Label();
            this.label_motion_cycle_move_speed = new System.Windows.Forms.Label();
            this.label_motion_cycle_step = new System.Windows.Forms.Label();
            this.label_motion_cycle_move = new System.Windows.Forms.Label();
            this.toggle_motion_cycle_axis = new ACSMotion.Control.ToggleButton();
            this.label_motion_cycle_start_y = new System.Windows.Forms.Label();
            this.label_motion_cycle_start_x = new System.Windows.Forms.Label();
            this.panel_motion_preset = new System.Windows.Forms.Panel();
            this.button_motion_preset_depth = new System.Windows.Forms.Button();
            this.button_motion_preset_vision = new System.Windows.Forms.Button();
            this.button_motion_preset_laser = new System.Windows.Forms.Button();
            this.button_motion_preset_save = new System.Windows.Forms.Button();
            this.button_motion_preset_move = new System.Windows.Forms.Button();
            this.button_motion_preset_cancel = new System.Windows.Forms.Button();
            this.label_motion_preset_t = new System.Windows.Forms.Label();
            this.label_motion_preset_y = new System.Windows.Forms.Label();
            this.textBox_motion_preset_pos_t = new System.Windows.Forms.TextBox();
            this.label_motion_preset_x = new System.Windows.Forms.Label();
            this.button_motion_preset_apply = new System.Windows.Forms.Button();
            this.button_motion_preset_set_current = new System.Windows.Forms.Button();
            this.textBox_motion_preset_pos_y = new System.Windows.Forms.TextBox();
            this.textBox_motion_preset_pos_x = new System.Windows.Forms.TextBox();
            this.button_motion_preset_8 = new System.Windows.Forms.Button();
            this.button_motion_preset_7 = new System.Windows.Forms.Button();
            this.button_motion_preset_6 = new System.Windows.Forms.Button();
            this.button_motion_preset_5 = new System.Windows.Forms.Button();
            this.button_motion_preset_4 = new System.Windows.Forms.Button();
            this.button_motion_preset_3 = new System.Windows.Forms.Button();
            this.button_motion_preset_2 = new System.Windows.Forms.Button();
            this.button_motion_preset_1 = new System.Windows.Forms.Button();
            this.panel_simple_move = new System.Windows.Forms.Panel();
            this.label_simple_move_input = new System.Windows.Forms.Label();
            this.label_simple_move_speed = new System.Windows.Forms.Label();
            this.label_simple_move_actual = new System.Windows.Forms.Label();
            this.label_simple_move_command = new System.Windows.Forms.Label();
            this.label_motion_move_rel = new System.Windows.Forms.Label();
            this.label_motion_move_abs = new System.Windows.Forms.Label();
            this.textBox_motion_x_command = new System.Windows.Forms.TextBox();
            this.toggle_move = new ACSMotion.Control.ToggleButton();
            this.textBox_motion_y_command = new System.Windows.Forms.TextBox();
            this.textBox_motion_t_command = new System.Windows.Forms.TextBox();
            this.textBox_motion_x_actual = new System.Windows.Forms.TextBox();
            this.textBox_motion_y_actual = new System.Windows.Forms.TextBox();
            this.textBox_motion_t_actual = new System.Windows.Forms.TextBox();
            this.button_motion_t_move = new System.Windows.Forms.Button();
            this.textBox_motion_x_speed = new System.Windows.Forms.TextBox();
            this.textBox_motion_t_input = new System.Windows.Forms.TextBox();
            this.textBox_motion_y_speed = new System.Windows.Forms.TextBox();
            this.button_motion_y_move = new System.Windows.Forms.Button();
            this.textBox_motion_t_speed = new System.Windows.Forms.TextBox();
            this.textBox_motion_y_input = new System.Windows.Forms.TextBox();
            this.textBox_motion_x_input = new System.Windows.Forms.TextBox();
            this.button_motion_x_move = new System.Windows.Forms.Button();
            this.panel_motion_status_t = new System.Windows.Forms.Panel();
            this.pictureBox_motion_status_t_homedone = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_t_moving = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_t_enable = new System.Windows.Forms.PictureBox();
            this.label_motion_status_t_homedone = new System.Windows.Forms.Label();
            this.label_motion_status_t_moving = new System.Windows.Forms.Label();
            this.label_motion_status_t_enable = new System.Windows.Forms.Label();
            this.panel_motion_status_y = new System.Windows.Forms.Panel();
            this.pictureBox_motion_status_y_homedone = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_y_moving = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_y_enable = new System.Windows.Forms.PictureBox();
            this.label_motion_status_y_homedone = new System.Windows.Forms.Label();
            this.label_motion_status_y_moving = new System.Windows.Forms.Label();
            this.label_motion_status_y_enable = new System.Windows.Forms.Label();
            this.panel_motion_status_x = new System.Windows.Forms.Panel();
            this.pictureBox_motion_status_x_homedone = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_x_moving = new System.Windows.Forms.PictureBox();
            this.pictureBox_motion_status_x_enable = new System.Windows.Forms.PictureBox();
            this.label_motion_status_x_homedone = new System.Windows.Forms.Label();
            this.label_motion_status_x_moving = new System.Windows.Forms.Label();
            this.label_motion_status_x_enable = new System.Windows.Forms.Label();
            this.button_motion_connect = new System.Windows.Forms.Button();
            this.button_process_stop = new System.Windows.Forms.Button();
            this.button_process_start = new System.Windows.Forms.Button();
            this.panel_wdi = new System.Windows.Forms.Panel();
            this.label_wdi_pitch = new System.Windows.Forms.Label();
            this.button_wdi_set_high = new System.Windows.Forms.Button();
            this.button_wdi_set_low = new System.Windows.Forms.Button();
            this.textBox_wdi_step = new System.Windows.Forms.TextBox();
            this.comboBox_wdi_image_split = new System.Windows.Forms.ComboBox();
            this.label_wdi_image_split = new System.Windows.Forms.Label();
            this.label_wdi_step = new System.Windows.Forms.Label();
            this.textBox_wdi_set_high = new System.Windows.Forms.TextBox();
            this.textBox_wdi_set_low = new System.Windows.Forms.TextBox();
            this.label_wdi_set_high = new System.Windows.Forms.Label();
            this.label_wdi_set_lower = new System.Windows.Forms.Label();
            this.button_wdi_move_stop = new System.Windows.Forms.Button();
            this.button_wdi_move_down = new System.Windows.Forms.Button();
            this.button_wdi_move_up = new System.Windows.Forms.Button();
            this.textBox_wdi_pitch = new System.Windows.Forms.TextBox();
            this.textBox_wdi_current_pos = new System.Windows.Forms.TextBox();
            this.button_wdi_home = new System.Windows.Forms.Button();
            this.button_wdi_connect = new System.Windows.Forms.Button();
            this.chart_result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_motion_stop = new System.Windows.Forms.Button();
            this.panel_vision_depth = new System.Windows.Forms.Panel();
            this.panel_vision_depth_display = new System.Windows.Forms.Panel();
            this.button_vision_depth_connect = new System.Windows.Forms.Button();
            this.pictureBox_colormap = new System.Windows.Forms.PictureBox();
            this.pictureBox_vision_color = new System.Windows.Forms.PictureBox();
            this.pictureBox_vision_merge = new System.Windows.Forms.PictureBox();
            this.elementHost_vision_3d = new System.Windows.Forms.Integration.ElementHost();
            this.button_depth_measure = new System.Windows.Forms.Button();
            this.panel_measure_width_1 = new System.Windows.Forms.Panel();
            this.panel_measure_width_2 = new System.Windows.Forms.Panel();
            this.panel_measure_width_3 = new System.Windows.Forms.Panel();
            this.panel_measure_height = new System.Windows.Forms.Panel();
            this.label_measure_width_1 = new System.Windows.Forms.Label();
            this.label_measure_width_2 = new System.Windows.Forms.Label();
            this.label_measure_width_3 = new System.Windows.Forms.Label();
            this.label_measure_height = new System.Windows.Forms.Label();
            this.textBox_measure_width_1 = new System.Windows.Forms.TextBox();
            this.textBox_measure_width_2 = new System.Windows.Forms.TextBox();
            this.textBox_measure_width_3 = new System.Windows.Forms.TextBox();
            this.textBox_measure_height = new System.Windows.Forms.TextBox();
            this.button_display_change = new System.Windows.Forms.Button();
            this.pictureBox_colormap_2 = new System.Windows.Forms.PictureBox();
            this.textBox_process_percent = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.panel_motion.SuspendLayout();
            this.panel_motion_cycle.SuspendLayout();
            this.panel_motion_preset.SuspendLayout();
            this.panel_simple_move.SuspendLayout();
            this.panel_motion_status_t.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_homedone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_moving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_enable)).BeginInit();
            this.panel_motion_status_y.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_homedone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_moving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_enable)).BeginInit();
            this.panel_motion_status_x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_homedone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_moving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_enable)).BeginInit();
            this.panel_wdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).BeginInit();
            this.panel_vision_depth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_colormap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vision_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vision_merge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_colormap_2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_motion
            // 
            this.panel_motion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion.Controls.Add(this.panel_motion_cycle);
            this.panel_motion.Controls.Add(this.panel_motion_preset);
            this.panel_motion.Controls.Add(this.panel_simple_move);
            this.panel_motion.Controls.Add(this.panel_motion_status_t);
            this.panel_motion.Controls.Add(this.panel_motion_status_y);
            this.panel_motion.Controls.Add(this.panel_motion_status_x);
            this.panel_motion.Controls.Add(this.button_motion_connect);
            this.panel_motion.Location = new System.Drawing.Point(10, 15);
            this.panel_motion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_motion.Name = "panel_motion";
            this.panel_motion.Size = new System.Drawing.Size(581, 845);
            this.panel_motion.TabIndex = 0;
            // 
            // panel_motion_cycle
            // 
            this.panel_motion_cycle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion_cycle.Controls.Add(this.button_motion_cycle_move);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_method_num);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_step_num);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_num);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_method_stroke);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_step_delay);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_step_max_stroke);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_step_speed);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_step);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_move_delay);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_move_speed);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_move);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_axis_y);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_axis_x);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_start_y);
            this.panel_motion_cycle.Controls.Add(this.textBox_motion_cycle_start_x);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_max_stroke);
            this.panel_motion_cycle.Controls.Add(this.toggle_motion_cycle_step_method);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_delay);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_move_delay);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step_speed);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_move_speed);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_step);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_move);
            this.panel_motion_cycle.Controls.Add(this.toggle_motion_cycle_axis);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_start_y);
            this.panel_motion_cycle.Controls.Add(this.label_motion_cycle_start_x);
            this.panel_motion_cycle.Location = new System.Drawing.Point(15, 590);
            this.panel_motion_cycle.Name = "panel_motion_cycle";
            this.panel_motion_cycle.Size = new System.Drawing.Size(550, 240);
            this.panel_motion_cycle.TabIndex = 45;
            // 
            // button_motion_cycle_move
            // 
            this.button_motion_cycle_move.Enabled = false;
            this.button_motion_cycle_move.Location = new System.Drawing.Point(450, 200);
            this.button_motion_cycle_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_cycle_move.Name = "button_motion_cycle_move";
            this.button_motion_cycle_move.Size = new System.Drawing.Size(80, 30);
            this.button_motion_cycle_move.TabIndex = 49;
            this.button_motion_cycle_move.Text = "이동";
            this.button_motion_cycle_move.UseVisualStyleBackColor = true;
            // 
            // label_motion_cycle_step_method_num
            // 
            this.label_motion_cycle_step_method_num.AutoSize = true;
            this.label_motion_cycle_step_method_num.Location = new System.Drawing.Point(475, 50);
            this.label_motion_cycle_step_method_num.MaximumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_num.MinimumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_num.Name = "label_motion_cycle_step_method_num";
            this.label_motion_cycle_step_method_num.Size = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_num.TabIndex = 48;
            this.label_motion_cycle_step_method_num.Text = "TIMES";
            this.label_motion_cycle_step_method_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_motion_cycle_step_num
            // 
            this.textBox_motion_cycle_step_num.Location = new System.Drawing.Point(460, 165);
            this.textBox_motion_cycle_step_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_step_num.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_num.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_num.Multiline = true;
            this.textBox_motion_cycle_step_num.Name = "textBox_motion_cycle_step_num";
            this.textBox_motion_cycle_step_num.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_num.TabIndex = 47;
            this.textBox_motion_cycle_step_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_motion_cycle_step_num
            // 
            this.label_motion_cycle_step_num.AutoSize = true;
            this.label_motion_cycle_step_num.Location = new System.Drawing.Point(375, 170);
            this.label_motion_cycle_step_num.Name = "label_motion_cycle_step_num";
            this.label_motion_cycle_step_num.Size = new System.Drawing.Size(62, 15);
            this.label_motion_cycle_step_num.TabIndex = 46;
            this.label_motion_cycle_step_num.Text = "Step Num";
            // 
            // label_motion_cycle_step_method_stroke
            // 
            this.label_motion_cycle_step_method_stroke.AutoSize = true;
            this.label_motion_cycle_step_method_stroke.Location = new System.Drawing.Point(330, 50);
            this.label_motion_cycle_step_method_stroke.MaximumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_stroke.MinimumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_stroke.Name = "label_motion_cycle_step_method_stroke";
            this.label_motion_cycle_step_method_stroke.Size = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_step_method_stroke.TabIndex = 44;
            this.label_motion_cycle_step_method_stroke.Text = "STROKE";
            this.label_motion_cycle_step_method_stroke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_motion_cycle_step_delay
            // 
            this.textBox_motion_cycle_step_delay.Location = new System.Drawing.Point(280, 200);
            this.textBox_motion_cycle_step_delay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_step_delay.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_delay.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_delay.Multiline = true;
            this.textBox_motion_cycle_step_delay.Name = "textBox_motion_cycle_step_delay";
            this.textBox_motion_cycle_step_delay.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_delay.TabIndex = 43;
            this.textBox_motion_cycle_step_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_step_max_stroke
            // 
            this.textBox_motion_cycle_step_max_stroke.Location = new System.Drawing.Point(460, 130);
            this.textBox_motion_cycle_step_max_stroke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_step_max_stroke.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_max_stroke.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_max_stroke.Multiline = true;
            this.textBox_motion_cycle_step_max_stroke.Name = "textBox_motion_cycle_step_max_stroke";
            this.textBox_motion_cycle_step_max_stroke.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_max_stroke.TabIndex = 42;
            this.textBox_motion_cycle_step_max_stroke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_step_speed
            // 
            this.textBox_motion_cycle_step_speed.Location = new System.Drawing.Point(280, 165);
            this.textBox_motion_cycle_step_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_step_speed.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_speed.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_speed.Multiline = true;
            this.textBox_motion_cycle_step_speed.Name = "textBox_motion_cycle_step_speed";
            this.textBox_motion_cycle_step_speed.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step_speed.TabIndex = 41;
            this.textBox_motion_cycle_step_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_step
            // 
            this.textBox_motion_cycle_step.Location = new System.Drawing.Point(280, 130);
            this.textBox_motion_cycle_step.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_step.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step.Multiline = true;
            this.textBox_motion_cycle_step.Name = "textBox_motion_cycle_step";
            this.textBox_motion_cycle_step.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_step.TabIndex = 40;
            this.textBox_motion_cycle_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_move_delay
            // 
            this.textBox_motion_cycle_move_delay.Location = new System.Drawing.Point(100, 200);
            this.textBox_motion_cycle_move_delay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_move_delay.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_delay.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_delay.Multiline = true;
            this.textBox_motion_cycle_move_delay.Name = "textBox_motion_cycle_move_delay";
            this.textBox_motion_cycle_move_delay.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_delay.TabIndex = 39;
            this.textBox_motion_cycle_move_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_move_speed
            // 
            this.textBox_motion_cycle_move_speed.Location = new System.Drawing.Point(100, 165);
            this.textBox_motion_cycle_move_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_move_speed.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_speed.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_speed.Multiline = true;
            this.textBox_motion_cycle_move_speed.Name = "textBox_motion_cycle_move_speed";
            this.textBox_motion_cycle_move_speed.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move_speed.TabIndex = 38;
            this.textBox_motion_cycle_move_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_move
            // 
            this.textBox_motion_cycle_move.Location = new System.Drawing.Point(100, 130);
            this.textBox_motion_cycle_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_move.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move.Multiline = true;
            this.textBox_motion_cycle_move.Name = "textBox_motion_cycle_move";
            this.textBox_motion_cycle_move.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_move.TabIndex = 37;
            this.textBox_motion_cycle_move.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_motion_cycle_axis_y
            // 
            this.label_motion_cycle_axis_y.AutoSize = true;
            this.label_motion_cycle_axis_y.Location = new System.Drawing.Point(475, 15);
            this.label_motion_cycle_axis_y.MaximumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_y.MinimumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_y.Name = "label_motion_cycle_axis_y";
            this.label_motion_cycle_axis_y.Size = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_y.TabIndex = 36;
            this.label_motion_cycle_axis_y.Text = "Y AXIS";
            this.label_motion_cycle_axis_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_motion_cycle_axis_x
            // 
            this.label_motion_cycle_axis_x.AutoSize = true;
            this.label_motion_cycle_axis_x.Location = new System.Drawing.Point(330, 15);
            this.label_motion_cycle_axis_x.MaximumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_x.MinimumSize = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_x.Name = "label_motion_cycle_axis_x";
            this.label_motion_cycle_axis_x.Size = new System.Drawing.Size(60, 15);
            this.label_motion_cycle_axis_x.TabIndex = 35;
            this.label_motion_cycle_axis_x.Text = "X AXIS";
            this.label_motion_cycle_axis_x.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_motion_cycle_start_y
            // 
            this.textBox_motion_cycle_start_y.Location = new System.Drawing.Point(100, 45);
            this.textBox_motion_cycle_start_y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_start_y.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_y.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_y.Multiline = true;
            this.textBox_motion_cycle_start_y.Name = "textBox_motion_cycle_start_y";
            this.textBox_motion_cycle_start_y.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_y.TabIndex = 34;
            this.textBox_motion_cycle_start_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_cycle_start_x
            // 
            this.textBox_motion_cycle_start_x.Location = new System.Drawing.Point(100, 10);
            this.textBox_motion_cycle_start_x.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_cycle_start_x.MaximumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_x.MinimumSize = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_x.Multiline = true;
            this.textBox_motion_cycle_start_x.Name = "textBox_motion_cycle_start_x";
            this.textBox_motion_cycle_start_x.Size = new System.Drawing.Size(70, 25);
            this.textBox_motion_cycle_start_x.TabIndex = 33;
            this.textBox_motion_cycle_start_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_motion_cycle_step_max_stroke
            // 
            this.label_motion_cycle_step_max_stroke.AutoSize = true;
            this.label_motion_cycle_step_max_stroke.Location = new System.Drawing.Point(375, 135);
            this.label_motion_cycle_step_max_stroke.Name = "label_motion_cycle_step_max_stroke";
            this.label_motion_cycle_step_max_stroke.Size = new System.Drawing.Size(66, 15);
            this.label_motion_cycle_step_max_stroke.TabIndex = 32;
            this.label_motion_cycle_step_max_stroke.Text = "Max Stroke";
            // 
            // toggle_motion_cycle_step_method
            // 
            this.toggle_motion_cycle_step_method.AutoSize = true;
            this.toggle_motion_cycle_step_method.Location = new System.Drawing.Point(405, 48);
            this.toggle_motion_cycle_step_method.MaximumSize = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_step_method.MinimumSize = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_step_method.Name = "toggle_motion_cycle_step_method";
            this.toggle_motion_cycle_step_method.OffBackColor = System.Drawing.Color.Lime;
            this.toggle_motion_cycle_step_method.OffToggleColor = System.Drawing.Color.Black;
            this.toggle_motion_cycle_step_method.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.toggle_motion_cycle_step_method.OnToggleColor = System.Drawing.Color.Black;
            this.toggle_motion_cycle_step_method.Size = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_step_method.TabIndex = 31;
            this.toggle_motion_cycle_step_method.Text = "toggleButton2";
            this.toggle_motion_cycle_step_method.UseVisualStyleBackColor = true;
            // 
            // label_motion_cycle_step_delay
            // 
            this.label_motion_cycle_step_delay.AutoSize = true;
            this.label_motion_cycle_step_delay.Location = new System.Drawing.Point(195, 205);
            this.label_motion_cycle_step_delay.Name = "label_motion_cycle_step_delay";
            this.label_motion_cycle_step_delay.Size = new System.Drawing.Size(66, 15);
            this.label_motion_cycle_step_delay.TabIndex = 30;
            this.label_motion_cycle_step_delay.Text = "Step Delay";
            // 
            // label_motion_cycle_move_delay
            // 
            this.label_motion_cycle_move_delay.AutoSize = true;
            this.label_motion_cycle_move_delay.Location = new System.Drawing.Point(15, 205);
            this.label_motion_cycle_move_delay.Name = "label_motion_cycle_move_delay";
            this.label_motion_cycle_move_delay.Size = new System.Drawing.Size(71, 15);
            this.label_motion_cycle_move_delay.TabIndex = 29;
            this.label_motion_cycle_move_delay.Text = "Cycle Delay";
            // 
            // label_motion_cycle_step_speed
            // 
            this.label_motion_cycle_step_speed.AutoSize = true;
            this.label_motion_cycle_step_speed.Location = new System.Drawing.Point(195, 170);
            this.label_motion_cycle_step_speed.Name = "label_motion_cycle_step_speed";
            this.label_motion_cycle_step_speed.Size = new System.Drawing.Size(71, 15);
            this.label_motion_cycle_step_speed.TabIndex = 28;
            this.label_motion_cycle_step_speed.Text = "Step Speed";
            // 
            // label_motion_cycle_move_speed
            // 
            this.label_motion_cycle_move_speed.AutoSize = true;
            this.label_motion_cycle_move_speed.Location = new System.Drawing.Point(15, 170);
            this.label_motion_cycle_move_speed.Name = "label_motion_cycle_move_speed";
            this.label_motion_cycle_move_speed.Size = new System.Drawing.Size(76, 15);
            this.label_motion_cycle_move_speed.TabIndex = 27;
            this.label_motion_cycle_move_speed.Text = "Cycle Speed";
            // 
            // label_motion_cycle_step
            // 
            this.label_motion_cycle_step.AutoSize = true;
            this.label_motion_cycle_step.Location = new System.Drawing.Point(195, 135);
            this.label_motion_cycle_step.Name = "label_motion_cycle_step";
            this.label_motion_cycle_step.Size = new System.Drawing.Size(63, 15);
            this.label_motion_cycle_step.TabIndex = 26;
            this.label_motion_cycle_step.Text = "Step Move";
            // 
            // label_motion_cycle_move
            // 
            this.label_motion_cycle_move.AutoSize = true;
            this.label_motion_cycle_move.Location = new System.Drawing.Point(15, 135);
            this.label_motion_cycle_move.Name = "label_motion_cycle_move";
            this.label_motion_cycle_move.Size = new System.Drawing.Size(68, 15);
            this.label_motion_cycle_move.TabIndex = 25;
            this.label_motion_cycle_move.Text = "Cycle Move";
            // 
            // toggle_motion_cycle_axis
            // 
            this.toggle_motion_cycle_axis.AutoSize = true;
            this.toggle_motion_cycle_axis.Location = new System.Drawing.Point(405, 13);
            this.toggle_motion_cycle_axis.MaximumSize = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_axis.MinimumSize = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_axis.Name = "toggle_motion_cycle_axis";
            this.toggle_motion_cycle_axis.OffBackColor = System.Drawing.Color.Lime;
            this.toggle_motion_cycle_axis.OffToggleColor = System.Drawing.Color.Black;
            this.toggle_motion_cycle_axis.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.toggle_motion_cycle_axis.OnToggleColor = System.Drawing.Color.Black;
            this.toggle_motion_cycle_axis.Size = new System.Drawing.Size(50, 20);
            this.toggle_motion_cycle_axis.TabIndex = 24;
            this.toggle_motion_cycle_axis.Text = "toggleButton1";
            this.toggle_motion_cycle_axis.UseVisualStyleBackColor = true;
            // 
            // label_motion_cycle_start_y
            // 
            this.label_motion_cycle_start_y.AutoSize = true;
            this.label_motion_cycle_start_y.Location = new System.Drawing.Point(15, 50);
            this.label_motion_cycle_start_y.Name = "label_motion_cycle_start_y";
            this.label_motion_cycle_start_y.Size = new System.Drawing.Size(50, 15);
            this.label_motion_cycle_start_y.TabIndex = 23;
            this.label_motion_cycle_start_y.Text = "Start (Y)";
            // 
            // label_motion_cycle_start_x
            // 
            this.label_motion_cycle_start_x.AutoSize = true;
            this.label_motion_cycle_start_x.Location = new System.Drawing.Point(15, 15);
            this.label_motion_cycle_start_x.Name = "label_motion_cycle_start_x";
            this.label_motion_cycle_start_x.Size = new System.Drawing.Size(50, 15);
            this.label_motion_cycle_start_x.TabIndex = 22;
            this.label_motion_cycle_start_x.Text = "Start (X)";
            // 
            // panel_motion_preset
            // 
            this.panel_motion_preset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_depth);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_vision);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_laser);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_save);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_move);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_cancel);
            this.panel_motion_preset.Controls.Add(this.label_motion_preset_t);
            this.panel_motion_preset.Controls.Add(this.label_motion_preset_y);
            this.panel_motion_preset.Controls.Add(this.textBox_motion_preset_pos_t);
            this.panel_motion_preset.Controls.Add(this.label_motion_preset_x);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_apply);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_set_current);
            this.panel_motion_preset.Controls.Add(this.textBox_motion_preset_pos_y);
            this.panel_motion_preset.Controls.Add(this.textBox_motion_preset_pos_x);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_8);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_7);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_6);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_5);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_4);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_3);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_2);
            this.panel_motion_preset.Controls.Add(this.button_motion_preset_1);
            this.panel_motion_preset.Location = new System.Drawing.Point(15, 400);
            this.panel_motion_preset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_motion_preset.Name = "panel_motion_preset";
            this.panel_motion_preset.Size = new System.Drawing.Size(550, 180);
            this.panel_motion_preset.TabIndex = 17;
            // 
            // button_motion_preset_depth
            // 
            this.button_motion_preset_depth.Enabled = false;
            this.button_motion_preset_depth.Location = new System.Drawing.Point(180, 90);
            this.button_motion_preset_depth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_depth.Name = "button_motion_preset_depth";
            this.button_motion_preset_depth.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_depth.TabIndex = 29;
            this.button_motion_preset_depth.Text = "Depth";
            this.button_motion_preset_depth.UseVisualStyleBackColor = true;
            this.button_motion_preset_depth.Click += new System.EventHandler(this.button_motion_preset_depth_Click);
            // 
            // button_motion_preset_vision
            // 
            this.button_motion_preset_vision.Enabled = false;
            this.button_motion_preset_vision.Location = new System.Drawing.Point(180, 51);
            this.button_motion_preset_vision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_vision.Name = "button_motion_preset_vision";
            this.button_motion_preset_vision.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_vision.TabIndex = 28;
            this.button_motion_preset_vision.Text = "Vision";
            this.button_motion_preset_vision.UseVisualStyleBackColor = true;
            this.button_motion_preset_vision.Click += new System.EventHandler(this.button_motion_preset_vision_Click);
            // 
            // button_motion_preset_laser
            // 
            this.button_motion_preset_laser.Enabled = false;
            this.button_motion_preset_laser.Location = new System.Drawing.Point(180, 10);
            this.button_motion_preset_laser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_laser.Name = "button_motion_preset_laser";
            this.button_motion_preset_laser.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_laser.TabIndex = 27;
            this.button_motion_preset_laser.Text = "Laser";
            this.button_motion_preset_laser.UseVisualStyleBackColor = true;
            this.button_motion_preset_laser.Click += new System.EventHandler(this.button_motion_preset_laser_Click);
            // 
            // button_motion_preset_save
            // 
            this.button_motion_preset_save.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_motion_preset_save.Location = new System.Drawing.Point(450, 90);
            this.button_motion_preset_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_save.Name = "button_motion_preset_save";
            this.button_motion_preset_save.Size = new System.Drawing.Size(80, 30);
            this.button_motion_preset_save.TabIndex = 26;
            this.button_motion_preset_save.Text = "저장";
            this.button_motion_preset_save.UseVisualStyleBackColor = true;
            this.button_motion_preset_save.Click += new System.EventHandler(this.button_motion_preset_save_Click);
            // 
            // button_motion_preset_move
            // 
            this.button_motion_preset_move.Enabled = false;
            this.button_motion_preset_move.Location = new System.Drawing.Point(450, 130);
            this.button_motion_preset_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_move.Name = "button_motion_preset_move";
            this.button_motion_preset_move.Size = new System.Drawing.Size(80, 30);
            this.button_motion_preset_move.TabIndex = 25;
            this.button_motion_preset_move.Text = "이동";
            this.button_motion_preset_move.UseVisualStyleBackColor = true;
            this.button_motion_preset_move.Click += new System.EventHandler(this.button_motion_preset_move_Click);
            // 
            // button_motion_preset_cancel
            // 
            this.button_motion_preset_cancel.Location = new System.Drawing.Point(450, 50);
            this.button_motion_preset_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_cancel.Name = "button_motion_preset_cancel";
            this.button_motion_preset_cancel.Size = new System.Drawing.Size(80, 30);
            this.button_motion_preset_cancel.TabIndex = 24;
            this.button_motion_preset_cancel.Text = "취소";
            this.button_motion_preset_cancel.UseVisualStyleBackColor = true;
            this.button_motion_preset_cancel.Click += new System.EventHandler(this.button_motion_preset_cancel_Click);
            // 
            // label_motion_preset_t
            // 
            this.label_motion_preset_t.AutoSize = true;
            this.label_motion_preset_t.Location = new System.Drawing.Point(295, 95);
            this.label_motion_preset_t.Name = "label_motion_preset_t";
            this.label_motion_preset_t.Size = new System.Drawing.Size(39, 15);
            this.label_motion_preset_t.TabIndex = 21;
            this.label_motion_preset_t.Text = "T Pos";
            // 
            // label_motion_preset_y
            // 
            this.label_motion_preset_y.AutoSize = true;
            this.label_motion_preset_y.Location = new System.Drawing.Point(295, 55);
            this.label_motion_preset_y.Name = "label_motion_preset_y";
            this.label_motion_preset_y.Size = new System.Drawing.Size(39, 15);
            this.label_motion_preset_y.TabIndex = 20;
            this.label_motion_preset_y.Text = "Y Pos";
            // 
            // textBox_motion_preset_pos_t
            // 
            this.textBox_motion_preset_pos_t.Location = new System.Drawing.Point(345, 90);
            this.textBox_motion_preset_pos_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_preset_pos_t.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_t.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_t.Multiline = true;
            this.textBox_motion_preset_pos_t.Name = "textBox_motion_preset_pos_t";
            this.textBox_motion_preset_pos_t.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_t.TabIndex = 19;
            this.textBox_motion_preset_pos_t.Text = "0.000";
            this.textBox_motion_preset_pos_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_motion_preset_x
            // 
            this.label_motion_preset_x.AutoSize = true;
            this.label_motion_preset_x.Location = new System.Drawing.Point(295, 15);
            this.label_motion_preset_x.Name = "label_motion_preset_x";
            this.label_motion_preset_x.Size = new System.Drawing.Size(39, 15);
            this.label_motion_preset_x.TabIndex = 18;
            this.label_motion_preset_x.Text = "X Pos";
            // 
            // button_motion_preset_apply
            // 
            this.button_motion_preset_apply.Location = new System.Drawing.Point(450, 10);
            this.button_motion_preset_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_apply.Name = "button_motion_preset_apply";
            this.button_motion_preset_apply.Size = new System.Drawing.Size(80, 30);
            this.button_motion_preset_apply.TabIndex = 13;
            this.button_motion_preset_apply.Text = "적용";
            this.button_motion_preset_apply.UseVisualStyleBackColor = true;
            this.button_motion_preset_apply.Click += new System.EventHandler(this.button_motion_preset_apply_Click);
            // 
            // button_motion_preset_set_current
            // 
            this.button_motion_preset_set_current.Location = new System.Drawing.Point(345, 130);
            this.button_motion_preset_set_current.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_set_current.Name = "button_motion_preset_set_current";
            this.button_motion_preset_set_current.Size = new System.Drawing.Size(80, 30);
            this.button_motion_preset_set_current.TabIndex = 12;
            this.button_motion_preset_set_current.Text = "현재 위치";
            this.button_motion_preset_set_current.UseVisualStyleBackColor = true;
            this.button_motion_preset_set_current.Click += new System.EventHandler(this.button_motion_preset_set_current_Click);
            // 
            // textBox_motion_preset_pos_y
            // 
            this.textBox_motion_preset_pos_y.Location = new System.Drawing.Point(345, 50);
            this.textBox_motion_preset_pos_y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_preset_pos_y.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_y.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_y.Multiline = true;
            this.textBox_motion_preset_pos_y.Name = "textBox_motion_preset_pos_y";
            this.textBox_motion_preset_pos_y.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_y.TabIndex = 11;
            this.textBox_motion_preset_pos_y.Text = "0.000";
            this.textBox_motion_preset_pos_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_preset_pos_x
            // 
            this.textBox_motion_preset_pos_x.Location = new System.Drawing.Point(345, 10);
            this.textBox_motion_preset_pos_x.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_preset_pos_x.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_x.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_x.Multiline = true;
            this.textBox_motion_preset_pos_x.Name = "textBox_motion_preset_pos_x";
            this.textBox_motion_preset_pos_x.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_preset_pos_x.TabIndex = 10;
            this.textBox_motion_preset_pos_x.Text = "0.000";
            this.textBox_motion_preset_pos_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_motion_preset_8
            // 
            this.button_motion_preset_8.Enabled = false;
            this.button_motion_preset_8.Location = new System.Drawing.Point(95, 130);
            this.button_motion_preset_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_8.Name = "button_motion_preset_8";
            this.button_motion_preset_8.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_8.TabIndex = 7;
            this.button_motion_preset_8.Text = "Preset 8";
            this.button_motion_preset_8.UseVisualStyleBackColor = true;
            this.button_motion_preset_8.Click += new System.EventHandler(this.button_motion_preset_8_Click);
            // 
            // button_motion_preset_7
            // 
            this.button_motion_preset_7.Enabled = false;
            this.button_motion_preset_7.Location = new System.Drawing.Point(95, 90);
            this.button_motion_preset_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_7.Name = "button_motion_preset_7";
            this.button_motion_preset_7.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_7.TabIndex = 6;
            this.button_motion_preset_7.Text = "Preset 7";
            this.button_motion_preset_7.UseVisualStyleBackColor = true;
            this.button_motion_preset_7.Click += new System.EventHandler(this.button_motion_preset_7_Click);
            // 
            // button_motion_preset_6
            // 
            this.button_motion_preset_6.Enabled = false;
            this.button_motion_preset_6.Location = new System.Drawing.Point(95, 50);
            this.button_motion_preset_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_6.Name = "button_motion_preset_6";
            this.button_motion_preset_6.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_6.TabIndex = 5;
            this.button_motion_preset_6.Text = "Preset 6";
            this.button_motion_preset_6.UseVisualStyleBackColor = true;
            this.button_motion_preset_6.Click += new System.EventHandler(this.button_motion_preset_6_Click);
            // 
            // button_motion_preset_5
            // 
            this.button_motion_preset_5.Enabled = false;
            this.button_motion_preset_5.Location = new System.Drawing.Point(95, 10);
            this.button_motion_preset_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_5.Name = "button_motion_preset_5";
            this.button_motion_preset_5.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_5.TabIndex = 4;
            this.button_motion_preset_5.Text = "Preset 5";
            this.button_motion_preset_5.UseVisualStyleBackColor = true;
            this.button_motion_preset_5.Click += new System.EventHandler(this.button_motion_preset_5_Click);
            // 
            // button_motion_preset_4
            // 
            this.button_motion_preset_4.Enabled = false;
            this.button_motion_preset_4.Location = new System.Drawing.Point(10, 130);
            this.button_motion_preset_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_4.Name = "button_motion_preset_4";
            this.button_motion_preset_4.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_4.TabIndex = 3;
            this.button_motion_preset_4.Text = "Preset 4";
            this.button_motion_preset_4.UseVisualStyleBackColor = true;
            this.button_motion_preset_4.Click += new System.EventHandler(this.button_motion_preset_4_Click);
            // 
            // button_motion_preset_3
            // 
            this.button_motion_preset_3.Enabled = false;
            this.button_motion_preset_3.Location = new System.Drawing.Point(10, 90);
            this.button_motion_preset_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_3.Name = "button_motion_preset_3";
            this.button_motion_preset_3.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_3.TabIndex = 2;
            this.button_motion_preset_3.Text = "Preset 3";
            this.button_motion_preset_3.UseVisualStyleBackColor = true;
            this.button_motion_preset_3.Click += new System.EventHandler(this.button_motion_preset_3_Click);
            // 
            // button_motion_preset_2
            // 
            this.button_motion_preset_2.Enabled = false;
            this.button_motion_preset_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_motion_preset_2.Location = new System.Drawing.Point(10, 50);
            this.button_motion_preset_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_2.Name = "button_motion_preset_2";
            this.button_motion_preset_2.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_2.TabIndex = 1;
            this.button_motion_preset_2.Text = "Preset 2";
            this.button_motion_preset_2.UseVisualStyleBackColor = true;
            this.button_motion_preset_2.Click += new System.EventHandler(this.button_motion_preset_2_Click);
            // 
            // button_motion_preset_1
            // 
            this.button_motion_preset_1.BackColor = System.Drawing.Color.Lime;
            this.button_motion_preset_1.Enabled = false;
            this.button_motion_preset_1.ForeColor = System.Drawing.Color.White;
            this.button_motion_preset_1.Location = new System.Drawing.Point(10, 10);
            this.button_motion_preset_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_preset_1.Name = "button_motion_preset_1";
            this.button_motion_preset_1.Size = new System.Drawing.Size(75, 30);
            this.button_motion_preset_1.TabIndex = 0;
            this.button_motion_preset_1.Text = "Preset 1";
            this.button_motion_preset_1.UseVisualStyleBackColor = false;
            this.button_motion_preset_1.Click += new System.EventHandler(this.button_motion_preset_1_Click);
            // 
            // panel_simple_move
            // 
            this.panel_simple_move.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_simple_move.Controls.Add(this.label_simple_move_input);
            this.panel_simple_move.Controls.Add(this.label_simple_move_speed);
            this.panel_simple_move.Controls.Add(this.label_simple_move_actual);
            this.panel_simple_move.Controls.Add(this.label_simple_move_command);
            this.panel_simple_move.Controls.Add(this.label_motion_move_rel);
            this.panel_simple_move.Controls.Add(this.label_motion_move_abs);
            this.panel_simple_move.Controls.Add(this.textBox_motion_x_command);
            this.panel_simple_move.Controls.Add(this.toggle_move);
            this.panel_simple_move.Controls.Add(this.textBox_motion_y_command);
            this.panel_simple_move.Controls.Add(this.textBox_motion_t_command);
            this.panel_simple_move.Controls.Add(this.textBox_motion_x_actual);
            this.panel_simple_move.Controls.Add(this.textBox_motion_y_actual);
            this.panel_simple_move.Controls.Add(this.textBox_motion_t_actual);
            this.panel_simple_move.Controls.Add(this.button_motion_t_move);
            this.panel_simple_move.Controls.Add(this.textBox_motion_x_speed);
            this.panel_simple_move.Controls.Add(this.textBox_motion_t_input);
            this.panel_simple_move.Controls.Add(this.textBox_motion_y_speed);
            this.panel_simple_move.Controls.Add(this.button_motion_y_move);
            this.panel_simple_move.Controls.Add(this.textBox_motion_t_speed);
            this.panel_simple_move.Controls.Add(this.textBox_motion_y_input);
            this.panel_simple_move.Controls.Add(this.textBox_motion_x_input);
            this.panel_simple_move.Controls.Add(this.button_motion_x_move);
            this.panel_simple_move.Location = new System.Drawing.Point(15, 210);
            this.panel_simple_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_simple_move.Name = "panel_simple_move";
            this.panel_simple_move.Size = new System.Drawing.Size(550, 170);
            this.panel_simple_move.TabIndex = 16;
            // 
            // label_simple_move_input
            // 
            this.label_simple_move_input.AutoSize = true;
            this.label_simple_move_input.Location = new System.Drawing.Point(330, 25);
            this.label_simple_move_input.Name = "label_simple_move_input";
            this.label_simple_move_input.Size = new System.Drawing.Size(34, 15);
            this.label_simple_move_input.TabIndex = 21;
            this.label_simple_move_input.Text = "Input";
            // 
            // label_simple_move_speed
            // 
            this.label_simple_move_speed.AutoSize = true;
            this.label_simple_move_speed.Location = new System.Drawing.Point(230, 25);
            this.label_simple_move_speed.Name = "label_simple_move_speed";
            this.label_simple_move_speed.Size = new System.Drawing.Size(43, 15);
            this.label_simple_move_speed.TabIndex = 20;
            this.label_simple_move_speed.Text = "Speed";
            // 
            // label_simple_move_actual
            // 
            this.label_simple_move_actual.AutoSize = true;
            this.label_simple_move_actual.Location = new System.Drawing.Point(130, 25);
            this.label_simple_move_actual.Name = "label_simple_move_actual";
            this.label_simple_move_actual.Size = new System.Drawing.Size(40, 15);
            this.label_simple_move_actual.TabIndex = 19;
            this.label_simple_move_actual.Text = "Actual";
            // 
            // label_simple_move_command
            // 
            this.label_simple_move_command.AutoSize = true;
            this.label_simple_move_command.Location = new System.Drawing.Point(15, 25);
            this.label_simple_move_command.Name = "label_simple_move_command";
            this.label_simple_move_command.Size = new System.Drawing.Size(66, 15);
            this.label_simple_move_command.TabIndex = 18;
            this.label_simple_move_command.Text = "Command";
            // 
            // label_motion_move_rel
            // 
            this.label_motion_move_rel.AutoSize = true;
            this.label_motion_move_rel.Location = new System.Drawing.Point(500, 25);
            this.label_motion_move_rel.Name = "label_motion_move_rel";
            this.label_motion_move_rel.Size = new System.Drawing.Size(31, 15);
            this.label_motion_move_rel.TabIndex = 17;
            this.label_motion_move_rel.Text = "REL";
            // 
            // label_motion_move_abs
            // 
            this.label_motion_move_abs.AutoSize = true;
            this.label_motion_move_abs.Location = new System.Drawing.Point(400, 25);
            this.label_motion_move_abs.Name = "label_motion_move_abs";
            this.label_motion_move_abs.Size = new System.Drawing.Size(30, 15);
            this.label_motion_move_abs.TabIndex = 16;
            this.label_motion_move_abs.Text = "ABS";
            // 
            // textBox_motion_x_command
            // 
            this.textBox_motion_x_command.Location = new System.Drawing.Point(10, 60);
            this.textBox_motion_x_command.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_x_command.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_command.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_command.Multiline = true;
            this.textBox_motion_x_command.Name = "textBox_motion_x_command";
            this.textBox_motion_x_command.ReadOnly = true;
            this.textBox_motion_x_command.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_command.TabIndex = 0;
            this.textBox_motion_x_command.Text = "0.000";
            this.textBox_motion_x_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toggle_move
            // 
            this.toggle_move.AutoSize = true;
            this.toggle_move.Enabled = false;
            this.toggle_move.Location = new System.Drawing.Point(440, 22);
            this.toggle_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggle_move.MaximumSize = new System.Drawing.Size(50, 20);
            this.toggle_move.MinimumSize = new System.Drawing.Size(50, 20);
            this.toggle_move.Name = "toggle_move";
            this.toggle_move.OffBackColor = System.Drawing.Color.Lime;
            this.toggle_move.OffToggleColor = System.Drawing.Color.Black;
            this.toggle_move.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.toggle_move.OnToggleColor = System.Drawing.Color.Black;
            this.toggle_move.Size = new System.Drawing.Size(50, 20);
            this.toggle_move.TabIndex = 15;
            this.toggle_move.Text = "toggleButton1";
            this.toggle_move.UseVisualStyleBackColor = true;
            this.toggle_move.CheckedChanged += new System.EventHandler(this.toggle_move_CheckedChanged);
            // 
            // textBox_motion_y_command
            // 
            this.textBox_motion_y_command.Location = new System.Drawing.Point(10, 95);
            this.textBox_motion_y_command.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_y_command.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_command.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_command.Multiline = true;
            this.textBox_motion_y_command.Name = "textBox_motion_y_command";
            this.textBox_motion_y_command.ReadOnly = true;
            this.textBox_motion_y_command.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_command.TabIndex = 1;
            this.textBox_motion_y_command.Text = "0.000";
            this.textBox_motion_y_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_t_command
            // 
            this.textBox_motion_t_command.AcceptsReturn = true;
            this.textBox_motion_t_command.Location = new System.Drawing.Point(10, 130);
            this.textBox_motion_t_command.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_t_command.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_command.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_command.Multiline = true;
            this.textBox_motion_t_command.Name = "textBox_motion_t_command";
            this.textBox_motion_t_command.ReadOnly = true;
            this.textBox_motion_t_command.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_command.TabIndex = 2;
            this.textBox_motion_t_command.Text = "0.000";
            this.textBox_motion_t_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_x_actual
            // 
            this.textBox_motion_x_actual.Location = new System.Drawing.Point(110, 60);
            this.textBox_motion_x_actual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_x_actual.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_actual.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_actual.Multiline = true;
            this.textBox_motion_x_actual.Name = "textBox_motion_x_actual";
            this.textBox_motion_x_actual.ReadOnly = true;
            this.textBox_motion_x_actual.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_actual.TabIndex = 3;
            this.textBox_motion_x_actual.Text = "0.000";
            this.textBox_motion_x_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_y_actual
            // 
            this.textBox_motion_y_actual.Location = new System.Drawing.Point(110, 95);
            this.textBox_motion_y_actual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_y_actual.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_actual.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_actual.Multiline = true;
            this.textBox_motion_y_actual.Name = "textBox_motion_y_actual";
            this.textBox_motion_y_actual.ReadOnly = true;
            this.textBox_motion_y_actual.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_actual.TabIndex = 4;
            this.textBox_motion_y_actual.Text = "0.000";
            this.textBox_motion_y_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_t_actual
            // 
            this.textBox_motion_t_actual.AcceptsReturn = true;
            this.textBox_motion_t_actual.Location = new System.Drawing.Point(110, 130);
            this.textBox_motion_t_actual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_t_actual.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_actual.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_actual.Multiline = true;
            this.textBox_motion_t_actual.Name = "textBox_motion_t_actual";
            this.textBox_motion_t_actual.ReadOnly = true;
            this.textBox_motion_t_actual.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_actual.TabIndex = 5;
            this.textBox_motion_t_actual.Text = "0.000";
            this.textBox_motion_t_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_motion_t_move
            // 
            this.button_motion_t_move.Enabled = false;
            this.button_motion_t_move.Location = new System.Drawing.Point(448, 129);
            this.button_motion_t_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_t_move.Name = "button_motion_t_move";
            this.button_motion_t_move.Size = new System.Drawing.Size(80, 25);
            this.button_motion_t_move.TabIndex = 4;
            this.button_motion_t_move.Text = "MOVE";
            this.button_motion_t_move.UseVisualStyleBackColor = true;
            this.button_motion_t_move.Click += new System.EventHandler(this.button_motion_t_move_Click);
            // 
            // textBox_motion_x_speed
            // 
            this.textBox_motion_x_speed.Location = new System.Drawing.Point(210, 60);
            this.textBox_motion_x_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_x_speed.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_speed.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_speed.Multiline = true;
            this.textBox_motion_x_speed.Name = "textBox_motion_x_speed";
            this.textBox_motion_x_speed.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_speed.TabIndex = 6;
            this.textBox_motion_x_speed.Text = "10.000";
            this.textBox_motion_x_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_t_input
            // 
            this.textBox_motion_t_input.AcceptsReturn = true;
            this.textBox_motion_t_input.Location = new System.Drawing.Point(310, 130);
            this.textBox_motion_t_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_t_input.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_input.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_input.Multiline = true;
            this.textBox_motion_t_input.Name = "textBox_motion_t_input";
            this.textBox_motion_t_input.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_input.TabIndex = 11;
            this.textBox_motion_t_input.Text = "0.000";
            this.textBox_motion_t_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_motion_t_input.TextChanged += new System.EventHandler(this.textBox_motion_t_input_TextChanged);
            // 
            // textBox_motion_y_speed
            // 
            this.textBox_motion_y_speed.Location = new System.Drawing.Point(210, 95);
            this.textBox_motion_y_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_y_speed.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_speed.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_speed.Multiline = true;
            this.textBox_motion_y_speed.Name = "textBox_motion_y_speed";
            this.textBox_motion_y_speed.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_speed.TabIndex = 7;
            this.textBox_motion_y_speed.Text = "10.000";
            this.textBox_motion_y_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_motion_y_move
            // 
            this.button_motion_y_move.Enabled = false;
            this.button_motion_y_move.Location = new System.Drawing.Point(448, 95);
            this.button_motion_y_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_y_move.Name = "button_motion_y_move";
            this.button_motion_y_move.Size = new System.Drawing.Size(80, 25);
            this.button_motion_y_move.TabIndex = 3;
            this.button_motion_y_move.Text = "MOVE";
            this.button_motion_y_move.UseVisualStyleBackColor = true;
            this.button_motion_y_move.Click += new System.EventHandler(this.button_motion_y_move_Click);
            // 
            // textBox_motion_t_speed
            // 
            this.textBox_motion_t_speed.AcceptsReturn = true;
            this.textBox_motion_t_speed.Location = new System.Drawing.Point(210, 130);
            this.textBox_motion_t_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_t_speed.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_speed.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_speed.Multiline = true;
            this.textBox_motion_t_speed.Name = "textBox_motion_t_speed";
            this.textBox_motion_t_speed.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_t_speed.TabIndex = 8;
            this.textBox_motion_t_speed.Text = "10.000";
            this.textBox_motion_t_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_motion_y_input
            // 
            this.textBox_motion_y_input.Location = new System.Drawing.Point(310, 95);
            this.textBox_motion_y_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_y_input.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_input.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_input.Multiline = true;
            this.textBox_motion_y_input.Name = "textBox_motion_y_input";
            this.textBox_motion_y_input.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_y_input.TabIndex = 10;
            this.textBox_motion_y_input.Text = "0.000";
            this.textBox_motion_y_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_motion_y_input.TextChanged += new System.EventHandler(this.textBox_motion_y_input_TextChanged);
            // 
            // textBox_motion_x_input
            // 
            this.textBox_motion_x_input.Location = new System.Drawing.Point(310, 60);
            this.textBox_motion_x_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_motion_x_input.MaximumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_input.MinimumSize = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_input.Multiline = true;
            this.textBox_motion_x_input.Name = "textBox_motion_x_input";
            this.textBox_motion_x_input.Size = new System.Drawing.Size(80, 25);
            this.textBox_motion_x_input.TabIndex = 9;
            this.textBox_motion_x_input.Text = "0.000";
            this.textBox_motion_x_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_motion_x_input.TextChanged += new System.EventHandler(this.textBox_motion_x_input_TextChanged);
            // 
            // button_motion_x_move
            // 
            this.button_motion_x_move.Enabled = false;
            this.button_motion_x_move.Location = new System.Drawing.Point(448, 60);
            this.button_motion_x_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_x_move.Name = "button_motion_x_move";
            this.button_motion_x_move.Size = new System.Drawing.Size(80, 25);
            this.button_motion_x_move.TabIndex = 2;
            this.button_motion_x_move.Text = "MOVE";
            this.button_motion_x_move.UseVisualStyleBackColor = true;
            this.button_motion_x_move.Click += new System.EventHandler(this.button_motion_x_move_Click);
            // 
            // panel_motion_status_t
            // 
            this.panel_motion_status_t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion_status_t.Controls.Add(this.pictureBox_motion_status_t_homedone);
            this.panel_motion_status_t.Controls.Add(this.pictureBox_motion_status_t_moving);
            this.panel_motion_status_t.Controls.Add(this.pictureBox_motion_status_t_enable);
            this.panel_motion_status_t.Controls.Add(this.label_motion_status_t_homedone);
            this.panel_motion_status_t.Controls.Add(this.label_motion_status_t_moving);
            this.panel_motion_status_t.Controls.Add(this.label_motion_status_t_enable);
            this.panel_motion_status_t.Location = new System.Drawing.Point(396, 50);
            this.panel_motion_status_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_motion_status_t.Name = "panel_motion_status_t";
            this.panel_motion_status_t.Size = new System.Drawing.Size(170, 150);
            this.panel_motion_status_t.TabIndex = 14;
            // 
            // pictureBox_motion_status_t_homedone
            // 
            this.pictureBox_motion_status_t_homedone.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_t_homedone.Enabled = false;
            this.pictureBox_motion_status_t_homedone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_t_homedone.Image")));
            this.pictureBox_motion_status_t_homedone.Location = new System.Drawing.Point(120, 100);
            this.pictureBox_motion_status_t_homedone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_t_homedone.Name = "pictureBox_motion_status_t_homedone";
            this.pictureBox_motion_status_t_homedone.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_t_homedone.TabIndex = 11;
            this.pictureBox_motion_status_t_homedone.TabStop = false;
            this.pictureBox_motion_status_t_homedone.Click += new System.EventHandler(this.pictureBox_motion_status_t_homedone_Click);
            // 
            // pictureBox_motion_status_t_moving
            // 
            this.pictureBox_motion_status_t_moving.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_t_moving.Enabled = false;
            this.pictureBox_motion_status_t_moving.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_t_moving.Image")));
            this.pictureBox_motion_status_t_moving.Location = new System.Drawing.Point(120, 55);
            this.pictureBox_motion_status_t_moving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_t_moving.Name = "pictureBox_motion_status_t_moving";
            this.pictureBox_motion_status_t_moving.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_t_moving.TabIndex = 10;
            this.pictureBox_motion_status_t_moving.TabStop = false;
            // 
            // pictureBox_motion_status_t_enable
            // 
            this.pictureBox_motion_status_t_enable.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_t_enable.Enabled = false;
            this.pictureBox_motion_status_t_enable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_t_enable.Image")));
            this.pictureBox_motion_status_t_enable.Location = new System.Drawing.Point(120, 10);
            this.pictureBox_motion_status_t_enable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_t_enable.Name = "pictureBox_motion_status_t_enable";
            this.pictureBox_motion_status_t_enable.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_t_enable.TabIndex = 9;
            this.pictureBox_motion_status_t_enable.TabStop = false;
            this.pictureBox_motion_status_t_enable.Click += new System.EventHandler(this.pictureBox_motion_status_t_enable_Click);
            // 
            // label_motion_status_t_homedone
            // 
            this.label_motion_status_t_homedone.AutoSize = true;
            this.label_motion_status_t_homedone.Location = new System.Drawing.Point(10, 105);
            this.label_motion_status_t_homedone.Name = "label_motion_status_t_homedone";
            this.label_motion_status_t_homedone.Size = new System.Drawing.Size(69, 15);
            this.label_motion_status_t_homedone.TabIndex = 5;
            this.label_motion_status_t_homedone.Text = "Homedone";
            // 
            // label_motion_status_t_moving
            // 
            this.label_motion_status_t_moving.AutoSize = true;
            this.label_motion_status_t_moving.Location = new System.Drawing.Point(10, 60);
            this.label_motion_status_t_moving.Name = "label_motion_status_t_moving";
            this.label_motion_status_t_moving.Size = new System.Drawing.Size(45, 15);
            this.label_motion_status_t_moving.TabIndex = 4;
            this.label_motion_status_t_moving.Text = "Moving";
            // 
            // label_motion_status_t_enable
            // 
            this.label_motion_status_t_enable.AutoSize = true;
            this.label_motion_status_t_enable.Location = new System.Drawing.Point(10, 15);
            this.label_motion_status_t_enable.Name = "label_motion_status_t_enable";
            this.label_motion_status_t_enable.Size = new System.Drawing.Size(46, 15);
            this.label_motion_status_t_enable.TabIndex = 3;
            this.label_motion_status_t_enable.Text = "Enable";
            // 
            // panel_motion_status_y
            // 
            this.panel_motion_status_y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion_status_y.Controls.Add(this.pictureBox_motion_status_y_homedone);
            this.panel_motion_status_y.Controls.Add(this.pictureBox_motion_status_y_moving);
            this.panel_motion_status_y.Controls.Add(this.pictureBox_motion_status_y_enable);
            this.panel_motion_status_y.Controls.Add(this.label_motion_status_y_homedone);
            this.panel_motion_status_y.Controls.Add(this.label_motion_status_y_moving);
            this.panel_motion_status_y.Controls.Add(this.label_motion_status_y_enable);
            this.panel_motion_status_y.Location = new System.Drawing.Point(203, 50);
            this.panel_motion_status_y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_motion_status_y.Name = "panel_motion_status_y";
            this.panel_motion_status_y.Size = new System.Drawing.Size(170, 150);
            this.panel_motion_status_y.TabIndex = 13;
            // 
            // pictureBox_motion_status_y_homedone
            // 
            this.pictureBox_motion_status_y_homedone.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_y_homedone.Enabled = false;
            this.pictureBox_motion_status_y_homedone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_y_homedone.Image")));
            this.pictureBox_motion_status_y_homedone.Location = new System.Drawing.Point(120, 100);
            this.pictureBox_motion_status_y_homedone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_y_homedone.Name = "pictureBox_motion_status_y_homedone";
            this.pictureBox_motion_status_y_homedone.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_y_homedone.TabIndex = 8;
            this.pictureBox_motion_status_y_homedone.TabStop = false;
            this.pictureBox_motion_status_y_homedone.Click += new System.EventHandler(this.pictureBox_motion_status_y_homedone_Click);
            // 
            // pictureBox_motion_status_y_moving
            // 
            this.pictureBox_motion_status_y_moving.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_y_moving.Enabled = false;
            this.pictureBox_motion_status_y_moving.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_y_moving.Image")));
            this.pictureBox_motion_status_y_moving.Location = new System.Drawing.Point(120, 55);
            this.pictureBox_motion_status_y_moving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_y_moving.Name = "pictureBox_motion_status_y_moving";
            this.pictureBox_motion_status_y_moving.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_y_moving.TabIndex = 7;
            this.pictureBox_motion_status_y_moving.TabStop = false;
            // 
            // pictureBox_motion_status_y_enable
            // 
            this.pictureBox_motion_status_y_enable.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_y_enable.Enabled = false;
            this.pictureBox_motion_status_y_enable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_y_enable.Image")));
            this.pictureBox_motion_status_y_enable.Location = new System.Drawing.Point(120, 10);
            this.pictureBox_motion_status_y_enable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_y_enable.Name = "pictureBox_motion_status_y_enable";
            this.pictureBox_motion_status_y_enable.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_y_enable.TabIndex = 6;
            this.pictureBox_motion_status_y_enable.TabStop = false;
            this.pictureBox_motion_status_y_enable.Click += new System.EventHandler(this.pictureBox_motion_status_y_enable_Click);
            // 
            // label_motion_status_y_homedone
            // 
            this.label_motion_status_y_homedone.AutoSize = true;
            this.label_motion_status_y_homedone.Location = new System.Drawing.Point(10, 105);
            this.label_motion_status_y_homedone.Name = "label_motion_status_y_homedone";
            this.label_motion_status_y_homedone.Size = new System.Drawing.Size(69, 15);
            this.label_motion_status_y_homedone.TabIndex = 5;
            this.label_motion_status_y_homedone.Text = "Homedone";
            // 
            // label_motion_status_y_moving
            // 
            this.label_motion_status_y_moving.AutoSize = true;
            this.label_motion_status_y_moving.Location = new System.Drawing.Point(10, 60);
            this.label_motion_status_y_moving.Name = "label_motion_status_y_moving";
            this.label_motion_status_y_moving.Size = new System.Drawing.Size(45, 15);
            this.label_motion_status_y_moving.TabIndex = 4;
            this.label_motion_status_y_moving.Text = "Moving";
            // 
            // label_motion_status_y_enable
            // 
            this.label_motion_status_y_enable.AutoSize = true;
            this.label_motion_status_y_enable.Location = new System.Drawing.Point(10, 15);
            this.label_motion_status_y_enable.Name = "label_motion_status_y_enable";
            this.label_motion_status_y_enable.Size = new System.Drawing.Size(46, 15);
            this.label_motion_status_y_enable.TabIndex = 3;
            this.label_motion_status_y_enable.Text = "Enable";
            // 
            // panel_motion_status_x
            // 
            this.panel_motion_status_x.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motion_status_x.Controls.Add(this.pictureBox_motion_status_x_homedone);
            this.panel_motion_status_x.Controls.Add(this.pictureBox_motion_status_x_moving);
            this.panel_motion_status_x.Controls.Add(this.pictureBox_motion_status_x_enable);
            this.panel_motion_status_x.Controls.Add(this.label_motion_status_x_homedone);
            this.panel_motion_status_x.Controls.Add(this.label_motion_status_x_moving);
            this.panel_motion_status_x.Controls.Add(this.label_motion_status_x_enable);
            this.panel_motion_status_x.Location = new System.Drawing.Point(15, 50);
            this.panel_motion_status_x.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_motion_status_x.Name = "panel_motion_status_x";
            this.panel_motion_status_x.Size = new System.Drawing.Size(170, 150);
            this.panel_motion_status_x.TabIndex = 12;
            // 
            // pictureBox_motion_status_x_homedone
            // 
            this.pictureBox_motion_status_x_homedone.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_x_homedone.Enabled = false;
            this.pictureBox_motion_status_x_homedone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_x_homedone.Image")));
            this.pictureBox_motion_status_x_homedone.Location = new System.Drawing.Point(120, 100);
            this.pictureBox_motion_status_x_homedone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_x_homedone.Name = "pictureBox_motion_status_x_homedone";
            this.pictureBox_motion_status_x_homedone.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_x_homedone.TabIndex = 5;
            this.pictureBox_motion_status_x_homedone.TabStop = false;
            this.pictureBox_motion_status_x_homedone.Click += new System.EventHandler(this.pictureBox_motion_status_x_homedone_Click);
            // 
            // pictureBox_motion_status_x_moving
            // 
            this.pictureBox_motion_status_x_moving.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_x_moving.Enabled = false;
            this.pictureBox_motion_status_x_moving.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_x_moving.Image")));
            this.pictureBox_motion_status_x_moving.Location = new System.Drawing.Point(120, 55);
            this.pictureBox_motion_status_x_moving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_x_moving.Name = "pictureBox_motion_status_x_moving";
            this.pictureBox_motion_status_x_moving.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_x_moving.TabIndex = 4;
            this.pictureBox_motion_status_x_moving.TabStop = false;
            // 
            // pictureBox_motion_status_x_enable
            // 
            this.pictureBox_motion_status_x_enable.BackColor = System.Drawing.Color.Black;
            this.pictureBox_motion_status_x_enable.Enabled = false;
            this.pictureBox_motion_status_x_enable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_motion_status_x_enable.Image")));
            this.pictureBox_motion_status_x_enable.Location = new System.Drawing.Point(120, 10);
            this.pictureBox_motion_status_x_enable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_motion_status_x_enable.Name = "pictureBox_motion_status_x_enable";
            this.pictureBox_motion_status_x_enable.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_motion_status_x_enable.TabIndex = 3;
            this.pictureBox_motion_status_x_enable.TabStop = false;
            this.pictureBox_motion_status_x_enable.Click += new System.EventHandler(this.pictureBox_motion_status_x_enable_Click);
            // 
            // label_motion_status_x_homedone
            // 
            this.label_motion_status_x_homedone.AutoSize = true;
            this.label_motion_status_x_homedone.Location = new System.Drawing.Point(10, 105);
            this.label_motion_status_x_homedone.Name = "label_motion_status_x_homedone";
            this.label_motion_status_x_homedone.Size = new System.Drawing.Size(69, 15);
            this.label_motion_status_x_homedone.TabIndex = 2;
            this.label_motion_status_x_homedone.Text = "Homedone";
            // 
            // label_motion_status_x_moving
            // 
            this.label_motion_status_x_moving.AutoSize = true;
            this.label_motion_status_x_moving.Location = new System.Drawing.Point(10, 60);
            this.label_motion_status_x_moving.Name = "label_motion_status_x_moving";
            this.label_motion_status_x_moving.Size = new System.Drawing.Size(45, 15);
            this.label_motion_status_x_moving.TabIndex = 1;
            this.label_motion_status_x_moving.Text = "Moving";
            // 
            // label_motion_status_x_enable
            // 
            this.label_motion_status_x_enable.AutoSize = true;
            this.label_motion_status_x_enable.Location = new System.Drawing.Point(10, 15);
            this.label_motion_status_x_enable.Name = "label_motion_status_x_enable";
            this.label_motion_status_x_enable.Size = new System.Drawing.Size(46, 15);
            this.label_motion_status_x_enable.TabIndex = 0;
            this.label_motion_status_x_enable.Text = "Enable";
            // 
            // button_motion_connect
            // 
            this.button_motion_connect.Location = new System.Drawing.Point(15, 10);
            this.button_motion_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_motion_connect.Name = "button_motion_connect";
            this.button_motion_connect.Size = new System.Drawing.Size(75, 29);
            this.button_motion_connect.TabIndex = 1;
            this.button_motion_connect.Text = "연결";
            this.button_motion_connect.UseVisualStyleBackColor = true;
            this.button_motion_connect.Click += new System.EventHandler(this.button_motion_connect_Click);
            // 
            // button_process_stop
            // 
            this.button_process_stop.Location = new System.Drawing.Point(600, 830);
            this.button_process_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_process_stop.Name = "button_process_stop";
            this.button_process_stop.Size = new System.Drawing.Size(80, 30);
            this.button_process_stop.TabIndex = 20;
            this.button_process_stop.Text = "Stop";
            this.button_process_stop.UseVisualStyleBackColor = true;
            this.button_process_stop.Click += new System.EventHandler(this.button_process_stop_Click);
            // 
            // button_process_start
            // 
            this.button_process_start.Location = new System.Drawing.Point(600, 795);
            this.button_process_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_process_start.Name = "button_process_start";
            this.button_process_start.Size = new System.Drawing.Size(80, 30);
            this.button_process_start.TabIndex = 19;
            this.button_process_start.Text = "Start";
            this.button_process_start.UseVisualStyleBackColor = true;
            this.button_process_start.Click += new System.EventHandler(this.button_process_start_Click);
            // 
            // panel_wdi
            // 
            this.panel_wdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_wdi.Controls.Add(this.label_wdi_pitch);
            this.panel_wdi.Controls.Add(this.button_wdi_set_high);
            this.panel_wdi.Controls.Add(this.button_wdi_set_low);
            this.panel_wdi.Controls.Add(this.textBox_wdi_step);
            this.panel_wdi.Controls.Add(this.comboBox_wdi_image_split);
            this.panel_wdi.Controls.Add(this.label_wdi_image_split);
            this.panel_wdi.Controls.Add(this.label_wdi_step);
            this.panel_wdi.Controls.Add(this.textBox_wdi_set_high);
            this.panel_wdi.Controls.Add(this.textBox_wdi_set_low);
            this.panel_wdi.Controls.Add(this.label_wdi_set_high);
            this.panel_wdi.Controls.Add(this.label_wdi_set_lower);
            this.panel_wdi.Controls.Add(this.button_wdi_move_stop);
            this.panel_wdi.Controls.Add(this.button_wdi_move_down);
            this.panel_wdi.Controls.Add(this.button_wdi_move_up);
            this.panel_wdi.Controls.Add(this.textBox_wdi_pitch);
            this.panel_wdi.Controls.Add(this.textBox_wdi_current_pos);
            this.panel_wdi.Controls.Add(this.button_wdi_home);
            this.panel_wdi.Controls.Add(this.button_wdi_connect);
            this.panel_wdi.Location = new System.Drawing.Point(600, 350);
            this.panel_wdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_wdi.Name = "panel_wdi";
            this.panel_wdi.Size = new System.Drawing.Size(299, 363);
            this.panel_wdi.TabIndex = 1;
            // 
            // label_wdi_pitch
            // 
            this.label_wdi_pitch.AutoSize = true;
            this.label_wdi_pitch.Location = new System.Drawing.Point(13, 133);
            this.label_wdi_pitch.MaximumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_pitch.MinimumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_pitch.Name = "label_wdi_pitch";
            this.label_wdi_pitch.Size = new System.Drawing.Size(80, 15);
            this.label_wdi_pitch.TabIndex = 33;
            this.label_wdi_pitch.Text = "Pitch";
            this.label_wdi_pitch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_wdi_set_high
            // 
            this.button_wdi_set_high.Location = new System.Drawing.Point(203, 240);
            this.button_wdi_set_high.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_set_high.Name = "button_wdi_set_high";
            this.button_wdi_set_high.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_set_high.TabIndex = 32;
            this.button_wdi_set_high.Text = "Set High";
            this.button_wdi_set_high.UseVisualStyleBackColor = true;
            this.button_wdi_set_high.Click += new System.EventHandler(this.button_wdi_set_high_Click);
            // 
            // button_wdi_set_low
            // 
            this.button_wdi_set_low.Location = new System.Drawing.Point(203, 200);
            this.button_wdi_set_low.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_set_low.Name = "button_wdi_set_low";
            this.button_wdi_set_low.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_set_low.TabIndex = 31;
            this.button_wdi_set_low.Text = "Set Low";
            this.button_wdi_set_low.UseVisualStyleBackColor = true;
            this.button_wdi_set_low.Click += new System.EventHandler(this.button_wdi_set_low_Click);
            // 
            // textBox_wdi_step
            // 
            this.textBox_wdi_step.Location = new System.Drawing.Point(108, 280);
            this.textBox_wdi_step.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wdi_step.Multiline = true;
            this.textBox_wdi_step.Name = "textBox_wdi_step";
            this.textBox_wdi_step.Size = new System.Drawing.Size(80, 25);
            this.textBox_wdi_step.TabIndex = 30;
            this.textBox_wdi_step.Text = "0.25";
            this.textBox_wdi_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_wdi_step.TextChanged += new System.EventHandler(this.textBox_wdi_step_TextChanged);
            // 
            // comboBox_wdi_image_split
            // 
            this.comboBox_wdi_image_split.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wdi_image_split.FormattingEnabled = true;
            this.comboBox_wdi_image_split.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox_wdi_image_split.ItemHeight = 15;
            this.comboBox_wdi_image_split.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.comboBox_wdi_image_split.Location = new System.Drawing.Point(108, 320);
            this.comboBox_wdi_image_split.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_wdi_image_split.Name = "comboBox_wdi_image_split";
            this.comboBox_wdi_image_split.Size = new System.Drawing.Size(80, 23);
            this.comboBox_wdi_image_split.TabIndex = 29;
            this.comboBox_wdi_image_split.SelectedIndexChanged += new System.EventHandler(this.comboBox_wdi_image_split_SelectedIndexChanged);
            // 
            // label_wdi_image_split
            // 
            this.label_wdi_image_split.AutoSize = true;
            this.label_wdi_image_split.Location = new System.Drawing.Point(13, 325);
            this.label_wdi_image_split.MaximumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_image_split.MinimumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_image_split.Name = "label_wdi_image_split";
            this.label_wdi_image_split.Size = new System.Drawing.Size(80, 15);
            this.label_wdi_image_split.TabIndex = 28;
            this.label_wdi_image_split.Text = "Image Split";
            this.label_wdi_image_split.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_wdi_step
            // 
            this.label_wdi_step.AutoSize = true;
            this.label_wdi_step.Location = new System.Drawing.Point(13, 285);
            this.label_wdi_step.MaximumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_step.MinimumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_step.Name = "label_wdi_step";
            this.label_wdi_step.Size = new System.Drawing.Size(80, 15);
            this.label_wdi_step.TabIndex = 27;
            this.label_wdi_step.Text = "Step (㎛)";
            this.label_wdi_step.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_wdi_set_high
            // 
            this.textBox_wdi_set_high.Location = new System.Drawing.Point(108, 240);
            this.textBox_wdi_set_high.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wdi_set_high.Multiline = true;
            this.textBox_wdi_set_high.Name = "textBox_wdi_set_high";
            this.textBox_wdi_set_high.Size = new System.Drawing.Size(80, 25);
            this.textBox_wdi_set_high.TabIndex = 26;
            this.textBox_wdi_set_high.Text = "10015";
            this.textBox_wdi_set_high.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_wdi_set_low
            // 
            this.textBox_wdi_set_low.Location = new System.Drawing.Point(108, 200);
            this.textBox_wdi_set_low.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wdi_set_low.Multiline = true;
            this.textBox_wdi_set_low.Name = "textBox_wdi_set_low";
            this.textBox_wdi_set_low.Size = new System.Drawing.Size(80, 25);
            this.textBox_wdi_set_low.TabIndex = 25;
            this.textBox_wdi_set_low.Text = "10000";
            this.textBox_wdi_set_low.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_wdi_set_high
            // 
            this.label_wdi_set_high.AutoSize = true;
            this.label_wdi_set_high.Location = new System.Drawing.Point(13, 245);
            this.label_wdi_set_high.MaximumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_set_high.MinimumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_set_high.Name = "label_wdi_set_high";
            this.label_wdi_set_high.Size = new System.Drawing.Size(80, 15);
            this.label_wdi_set_high.TabIndex = 24;
            this.label_wdi_set_high.Text = "Motion (High)";
            this.label_wdi_set_high.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_wdi_set_lower
            // 
            this.label_wdi_set_lower.AutoSize = true;
            this.label_wdi_set_lower.Location = new System.Drawing.Point(13, 205);
            this.label_wdi_set_lower.MaximumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_set_lower.MinimumSize = new System.Drawing.Size(80, 15);
            this.label_wdi_set_lower.Name = "label_wdi_set_lower";
            this.label_wdi_set_lower.Size = new System.Drawing.Size(80, 15);
            this.label_wdi_set_lower.TabIndex = 23;
            this.label_wdi_set_lower.Text = "Motion (Low)";
            this.label_wdi_set_lower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_wdi_move_stop
            // 
            this.button_wdi_move_stop.Location = new System.Drawing.Point(203, 128);
            this.button_wdi_move_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_move_stop.Name = "button_wdi_move_stop";
            this.button_wdi_move_stop.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_move_stop.TabIndex = 19;
            this.button_wdi_move_stop.Text = "STOP";
            this.button_wdi_move_stop.UseVisualStyleBackColor = true;
            this.button_wdi_move_stop.Click += new System.EventHandler(this.button_wdi_move_stop_Click);
            // 
            // button_wdi_move_down
            // 
            this.button_wdi_move_down.Location = new System.Drawing.Point(203, 86);
            this.button_wdi_move_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_move_down.Name = "button_wdi_move_down";
            this.button_wdi_move_down.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_move_down.TabIndex = 7;
            this.button_wdi_move_down.Text = "▽";
            this.button_wdi_move_down.UseVisualStyleBackColor = true;
            this.button_wdi_move_down.Click += new System.EventHandler(this.button_wdi_move_down_Click);
            // 
            // button_wdi_move_up
            // 
            this.button_wdi_move_up.Location = new System.Drawing.Point(203, 16);
            this.button_wdi_move_up.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_move_up.Name = "button_wdi_move_up";
            this.button_wdi_move_up.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_move_up.TabIndex = 6;
            this.button_wdi_move_up.Text = "△";
            this.button_wdi_move_up.UseVisualStyleBackColor = true;
            this.button_wdi_move_up.Click += new System.EventHandler(this.button_wdi_move_up_Click);
            // 
            // textBox_wdi_pitch
            // 
            this.textBox_wdi_pitch.Location = new System.Drawing.Point(108, 128);
            this.textBox_wdi_pitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wdi_pitch.Multiline = true;
            this.textBox_wdi_pitch.Name = "textBox_wdi_pitch";
            this.textBox_wdi_pitch.Size = new System.Drawing.Size(80, 25);
            this.textBox_wdi_pitch.TabIndex = 5;
            this.textBox_wdi_pitch.Text = "10000";
            this.textBox_wdi_pitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_wdi_pitch.TextChanged += new System.EventHandler(this.textBox_wdi_pitch_TextChanged);
            // 
            // textBox_wdi_current_pos
            // 
            this.textBox_wdi_current_pos.Location = new System.Drawing.Point(203, 53);
            this.textBox_wdi_current_pos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wdi_current_pos.Multiline = true;
            this.textBox_wdi_current_pos.Name = "textBox_wdi_current_pos";
            this.textBox_wdi_current_pos.Size = new System.Drawing.Size(80, 25);
            this.textBox_wdi_current_pos.TabIndex = 4;
            this.textBox_wdi_current_pos.Text = "10000";
            this.textBox_wdi_current_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_wdi_home
            // 
            this.button_wdi_home.Location = new System.Drawing.Point(10, 56);
            this.button_wdi_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_home.Name = "button_wdi_home";
            this.button_wdi_home.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_home.TabIndex = 3;
            this.button_wdi_home.Text = "HOME";
            this.button_wdi_home.UseVisualStyleBackColor = true;
            this.button_wdi_home.Click += new System.EventHandler(this.button_wdi_home_Click);
            // 
            // button_wdi_connect
            // 
            this.button_wdi_connect.Location = new System.Drawing.Point(10, 20);
            this.button_wdi_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wdi_connect.Name = "button_wdi_connect";
            this.button_wdi_connect.Size = new System.Drawing.Size(80, 25);
            this.button_wdi_connect.TabIndex = 0;
            this.button_wdi_connect.Text = "연결";
            this.button_wdi_connect.UseVisualStyleBackColor = true;
            this.button_wdi_connect.Click += new System.EventHandler(this.button_wdi_connect_Click);
            // 
            // chart_result
            // 
            this.chart_result.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chart_result.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_result.Legends.Add(legend1);
            this.chart_result.Location = new System.Drawing.Point(969, 550);
            this.chart_result.Name = "chart_result";
            this.chart_result.Size = new System.Drawing.Size(640, 300);
            this.chart_result.TabIndex = 8;
            this.chart_result.Text = "chart1";
            this.chart_result.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart_result_PostPaint);
            this.chart_result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_result_MouseClick);
            this.chart_result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_result_MouseMove);
            // 
            // button_motion_stop
            // 
            this.button_motion_stop.Location = new System.Drawing.Point(825, 790);
            this.button_motion_stop.Name = "button_motion_stop";
            this.button_motion_stop.Size = new System.Drawing.Size(70, 70);
            this.button_motion_stop.TabIndex = 21;
            this.button_motion_stop.Text = "Motion Stop";
            this.button_motion_stop.UseVisualStyleBackColor = true;
            this.button_motion_stop.Click += new System.EventHandler(this.button_motion_stop_Click);
            // 
            // panel_vision_depth
            // 
            this.panel_vision_depth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_vision_depth.Controls.Add(this.panel_vision_depth_display);
            this.panel_vision_depth.Controls.Add(this.button_vision_depth_connect);
            this.panel_vision_depth.Location = new System.Drawing.Point(600, 15);
            this.panel_vision_depth.Name = "panel_vision_depth";
            this.panel_vision_depth.Size = new System.Drawing.Size(299, 320);
            this.panel_vision_depth.TabIndex = 10;
            // 
            // panel_vision_depth_display
            // 
            this.panel_vision_depth_display.BackColor = System.Drawing.Color.Black;
            this.panel_vision_depth_display.Location = new System.Drawing.Point(10, 10);
            this.panel_vision_depth_display.Name = "panel_vision_depth_display";
            this.panel_vision_depth_display.Size = new System.Drawing.Size(254, 254);
            this.panel_vision_depth_display.TabIndex = 5;
            // 
            // button_vision_depth_connect
            // 
            this.button_vision_depth_connect.Location = new System.Drawing.Point(10, 273);
            this.button_vision_depth_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_vision_depth_connect.Name = "button_vision_depth_connect";
            this.button_vision_depth_connect.Size = new System.Drawing.Size(80, 25);
            this.button_vision_depth_connect.TabIndex = 4;
            this.button_vision_depth_connect.Text = "연결";
            this.button_vision_depth_connect.UseVisualStyleBackColor = true;
            this.button_vision_depth_connect.Click += new System.EventHandler(this.button_vision_depth_connect_Click);
            // 
            // pictureBox_colormap
            // 
            this.pictureBox_colormap.Location = new System.Drawing.Point(1518, 14);
            this.pictureBox_colormap.Name = "pictureBox_colormap";
            this.pictureBox_colormap.Size = new System.Drawing.Size(15, 512);
            this.pictureBox_colormap.TabIndex = 23;
            this.pictureBox_colormap.TabStop = false;
            // 
            // pictureBox_vision_color
            // 
            this.pictureBox_vision_color.BackColor = System.Drawing.Color.Black;
            this.pictureBox_vision_color.Location = new System.Drawing.Point(1600, 15);
            this.pictureBox_vision_color.Name = "pictureBox_vision_color";
            this.pictureBox_vision_color.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_vision_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_vision_color.TabIndex = 24;
            this.pictureBox_vision_color.TabStop = false;
            // 
            // pictureBox_vision_merge
            // 
            this.pictureBox_vision_merge.BackColor = System.Drawing.Color.Black;
            this.pictureBox_vision_merge.Location = new System.Drawing.Point(1000, 15);
            this.pictureBox_vision_merge.Name = "pictureBox_vision_merge";
            this.pictureBox_vision_merge.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_vision_merge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_vision_merge.TabIndex = 28;
            this.pictureBox_vision_merge.TabStop = false;
            this.pictureBox_vision_merge.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_vision_merge_Paint);
            this.pictureBox_vision_merge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_vision_merge_MouseDown);
            this.pictureBox_vision_merge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_vision_merge_MouseMove);
            // 
            // elementHost_vision_3d
            // 
            this.elementHost_vision_3d.BackColor = System.Drawing.Color.Black;
            this.elementHost_vision_3d.Location = new System.Drawing.Point(1600, 271);
            this.elementHost_vision_3d.Name = "elementHost_vision_3d";
            this.elementHost_vision_3d.Size = new System.Drawing.Size(256, 256);
            this.elementHost_vision_3d.TabIndex = 29;
            this.elementHost_vision_3d.Text = "elementHost1";
            this.elementHost_vision_3d.Child = null;
            // 
            // button_depth_measure
            // 
            this.button_depth_measure.Location = new System.Drawing.Point(1776, 800);
            this.button_depth_measure.Name = "button_depth_measure";
            this.button_depth_measure.Size = new System.Drawing.Size(80, 50);
            this.button_depth_measure.TabIndex = 30;
            this.button_depth_measure.Text = "Depth Measure";
            this.button_depth_measure.UseVisualStyleBackColor = true;
            this.button_depth_measure.Click += new System.EventHandler(this.button_depth_measure_Click);
            // 
            // panel_measure_width_1
            // 
            this.panel_measure_width_1.BackColor = System.Drawing.Color.Red;
            this.panel_measure_width_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_measure_width_1.Location = new System.Drawing.Point(1630, 565);
            this.panel_measure_width_1.Name = "panel_measure_width_1";
            this.panel_measure_width_1.Size = new System.Drawing.Size(40, 10);
            this.panel_measure_width_1.TabIndex = 31;
            // 
            // panel_measure_width_2
            // 
            this.panel_measure_width_2.BackColor = System.Drawing.Color.Orange;
            this.panel_measure_width_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_measure_width_2.Location = new System.Drawing.Point(1630, 600);
            this.panel_measure_width_2.Name = "panel_measure_width_2";
            this.panel_measure_width_2.Size = new System.Drawing.Size(40, 10);
            this.panel_measure_width_2.TabIndex = 32;
            // 
            // panel_measure_width_3
            // 
            this.panel_measure_width_3.BackColor = System.Drawing.Color.Blue;
            this.panel_measure_width_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_measure_width_3.Location = new System.Drawing.Point(1630, 635);
            this.panel_measure_width_3.Name = "panel_measure_width_3";
            this.panel_measure_width_3.Size = new System.Drawing.Size(40, 10);
            this.panel_measure_width_3.TabIndex = 33;
            // 
            // panel_measure_height
            // 
            this.panel_measure_height.BackColor = System.Drawing.Color.Green;
            this.panel_measure_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_measure_height.Location = new System.Drawing.Point(1630, 670);
            this.panel_measure_height.Name = "panel_measure_height";
            this.panel_measure_height.Size = new System.Drawing.Size(40, 10);
            this.panel_measure_height.TabIndex = 32;
            // 
            // label_measure_width_1
            // 
            this.label_measure_width_1.AutoSize = true;
            this.label_measure_width_1.Location = new System.Drawing.Point(1690, 560);
            this.label_measure_width_1.Name = "label_measure_width_1";
            this.label_measure_width_1.Size = new System.Drawing.Size(53, 15);
            this.label_measure_width_1.TabIndex = 34;
            this.label_measure_width_1.Text = "Width(1)";
            // 
            // label_measure_width_2
            // 
            this.label_measure_width_2.AutoSize = true;
            this.label_measure_width_2.Location = new System.Drawing.Point(1690, 595);
            this.label_measure_width_2.Name = "label_measure_width_2";
            this.label_measure_width_2.Size = new System.Drawing.Size(53, 15);
            this.label_measure_width_2.TabIndex = 35;
            this.label_measure_width_2.Text = "Width(2)";
            // 
            // label_measure_width_3
            // 
            this.label_measure_width_3.AutoSize = true;
            this.label_measure_width_3.Location = new System.Drawing.Point(1690, 630);
            this.label_measure_width_3.Name = "label_measure_width_3";
            this.label_measure_width_3.Size = new System.Drawing.Size(53, 15);
            this.label_measure_width_3.TabIndex = 36;
            this.label_measure_width_3.Text = "Width(3)";
            // 
            // label_measure_height
            // 
            this.label_measure_height.AutoSize = true;
            this.label_measure_height.Location = new System.Drawing.Point(1690, 665);
            this.label_measure_height.Name = "label_measure_height";
            this.label_measure_height.Size = new System.Drawing.Size(43, 15);
            this.label_measure_height.TabIndex = 37;
            this.label_measure_height.Text = "Height";
            // 
            // textBox_measure_width_1
            // 
            this.textBox_measure_width_1.Location = new System.Drawing.Point(1775, 555);
            this.textBox_measure_width_1.Multiline = true;
            this.textBox_measure_width_1.Name = "textBox_measure_width_1";
            this.textBox_measure_width_1.ReadOnly = true;
            this.textBox_measure_width_1.Size = new System.Drawing.Size(80, 25);
            this.textBox_measure_width_1.TabIndex = 38;
            this.textBox_measure_width_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_measure_width_2
            // 
            this.textBox_measure_width_2.Location = new System.Drawing.Point(1775, 590);
            this.textBox_measure_width_2.Multiline = true;
            this.textBox_measure_width_2.Name = "textBox_measure_width_2";
            this.textBox_measure_width_2.ReadOnly = true;
            this.textBox_measure_width_2.Size = new System.Drawing.Size(80, 25);
            this.textBox_measure_width_2.TabIndex = 39;
            this.textBox_measure_width_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_measure_width_3
            // 
            this.textBox_measure_width_3.Location = new System.Drawing.Point(1775, 625);
            this.textBox_measure_width_3.Multiline = true;
            this.textBox_measure_width_3.Name = "textBox_measure_width_3";
            this.textBox_measure_width_3.ReadOnly = true;
            this.textBox_measure_width_3.Size = new System.Drawing.Size(80, 25);
            this.textBox_measure_width_3.TabIndex = 40;
            this.textBox_measure_width_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_measure_height
            // 
            this.textBox_measure_height.Location = new System.Drawing.Point(1775, 660);
            this.textBox_measure_height.Multiline = true;
            this.textBox_measure_height.Name = "textBox_measure_height";
            this.textBox_measure_height.ReadOnly = true;
            this.textBox_measure_height.Size = new System.Drawing.Size(80, 25);
            this.textBox_measure_height.TabIndex = 41;
            this.textBox_measure_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_display_change
            // 
            this.button_display_change.Location = new System.Drawing.Point(1630, 800);
            this.button_display_change.Name = "button_display_change";
            this.button_display_change.Size = new System.Drawing.Size(80, 50);
            this.button_display_change.TabIndex = 42;
            this.button_display_change.Text = "Change";
            this.button_display_change.UseVisualStyleBackColor = true;
            this.button_display_change.Click += new System.EventHandler(this.button_display_change_Click);
            // 
            // pictureBox_colormap_2
            // 
            this.pictureBox_colormap_2.Location = new System.Drawing.Point(1862, 15);
            this.pictureBox_colormap_2.Name = "pictureBox_colormap_2";
            this.pictureBox_colormap_2.Size = new System.Drawing.Size(15, 256);
            this.pictureBox_colormap_2.TabIndex = 43;
            this.pictureBox_colormap_2.TabStop = false;
            // 
            // textBox_process_percent
            // 
            this.textBox_process_percent.Location = new System.Drawing.Point(690, 830);
            this.textBox_process_percent.Multiline = true;
            this.textBox_process_percent.Name = "textBox_process_percent";
            this.textBox_process_percent.Size = new System.Drawing.Size(120, 30);
            this.textBox_process_percent.TabIndex = 44;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(690, 794);
            this.textBox_number.Multiline = true;
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(120, 30);
            this.textBox_number.TabIndex = 45;
            this.textBox_number.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_process_percent);
            this.Controls.Add(this.pictureBox_colormap_2);
            this.Controls.Add(this.button_display_change);
            this.Controls.Add(this.textBox_measure_height);
            this.Controls.Add(this.textBox_measure_width_3);
            this.Controls.Add(this.textBox_measure_width_2);
            this.Controls.Add(this.textBox_measure_width_1);
            this.Controls.Add(this.label_measure_height);
            this.Controls.Add(this.label_measure_width_3);
            this.Controls.Add(this.label_measure_width_2);
            this.Controls.Add(this.label_measure_width_1);
            this.Controls.Add(this.panel_measure_height);
            this.Controls.Add(this.panel_measure_width_3);
            this.Controls.Add(this.panel_measure_width_2);
            this.Controls.Add(this.panel_measure_width_1);
            this.Controls.Add(this.button_depth_measure);
            this.Controls.Add(this.elementHost_vision_3d);
            this.Controls.Add(this.pictureBox_vision_merge);
            this.Controls.Add(this.pictureBox_vision_color);
            this.Controls.Add(this.pictureBox_colormap);
            this.Controls.Add(this.panel_vision_depth);
            this.Controls.Add(this.button_motion_stop);
            this.Controls.Add(this.button_process_stop);
            this.Controls.Add(this.chart_result);
            this.Controls.Add(this.button_process_start);
            this.Controls.Add(this.panel_wdi);
            this.Controls.Add(this.panel_motion);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel_motion.ResumeLayout(false);
            this.panel_motion_cycle.ResumeLayout(false);
            this.panel_motion_cycle.PerformLayout();
            this.panel_motion_preset.ResumeLayout(false);
            this.panel_motion_preset.PerformLayout();
            this.panel_simple_move.ResumeLayout(false);
            this.panel_simple_move.PerformLayout();
            this.panel_motion_status_t.ResumeLayout(false);
            this.panel_motion_status_t.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_homedone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_moving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_t_enable)).EndInit();
            this.panel_motion_status_y.ResumeLayout(false);
            this.panel_motion_status_y.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_homedone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_moving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_y_enable)).EndInit();
            this.panel_motion_status_x.ResumeLayout(false);
            this.panel_motion_status_x.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_homedone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_moving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motion_status_x_enable)).EndInit();
            this.panel_wdi.ResumeLayout(false);
            this.panel_wdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).EndInit();
            this.panel_vision_depth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_colormap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vision_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vision_merge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_colormap_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_motion;
        private System.Windows.Forms.Panel panel_motion_status_t;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_t_homedone;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_t_moving;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_t_enable;
        private System.Windows.Forms.Label label_motion_status_t_homedone;
        private System.Windows.Forms.Label label_motion_status_t_moving;
        private System.Windows.Forms.Label label_motion_status_t_enable;
        private System.Windows.Forms.Panel panel_motion_status_y;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_y_homedone;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_y_moving;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_y_enable;
        private System.Windows.Forms.Label label_motion_status_y_homedone;
        private System.Windows.Forms.Label label_motion_status_y_moving;
        private System.Windows.Forms.Label label_motion_status_y_enable;
        private System.Windows.Forms.Panel panel_motion_status_x;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_x_homedone;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_x_moving;
        private System.Windows.Forms.PictureBox pictureBox_motion_status_x_enable;
        private System.Windows.Forms.Label label_motion_status_x_homedone;
        private System.Windows.Forms.Label label_motion_status_x_moving;
        private System.Windows.Forms.Label label_motion_status_x_enable;
        private System.Windows.Forms.Button button_motion_connect;
        private System.Windows.Forms.Button button_motion_t_move;
        private System.Windows.Forms.TextBox textBox_motion_t_input;
        private System.Windows.Forms.Button button_motion_y_move;
        private System.Windows.Forms.TextBox textBox_motion_y_input;
        private System.Windows.Forms.Button button_motion_x_move;
        private System.Windows.Forms.TextBox textBox_motion_x_input;
        private System.Windows.Forms.TextBox textBox_motion_t_speed;
        private System.Windows.Forms.TextBox textBox_motion_y_speed;
        private System.Windows.Forms.TextBox textBox_motion_x_speed;
        private System.Windows.Forms.TextBox textBox_motion_t_actual;
        private System.Windows.Forms.TextBox textBox_motion_y_actual;
        private System.Windows.Forms.TextBox textBox_motion_x_actual;
        private System.Windows.Forms.TextBox textBox_motion_t_command;
        private System.Windows.Forms.TextBox textBox_motion_y_command;
        private System.Windows.Forms.TextBox textBox_motion_x_command;
        private System.Windows.Forms.Panel panel_motion_preset;
        private System.Windows.Forms.Button button_motion_preset_apply;
        private System.Windows.Forms.Button button_motion_preset_set_current;
        private System.Windows.Forms.TextBox textBox_motion_preset_pos_y;
        private System.Windows.Forms.TextBox textBox_motion_preset_pos_x;
        private System.Windows.Forms.Button button_motion_preset_8;
        private System.Windows.Forms.Button button_motion_preset_7;
        private System.Windows.Forms.Button button_motion_preset_6;
        private System.Windows.Forms.Button button_motion_preset_5;
        private System.Windows.Forms.Button button_motion_preset_4;
        private System.Windows.Forms.Button button_motion_preset_3;
        private System.Windows.Forms.Button button_motion_preset_2;
        private System.Windows.Forms.Button button_motion_preset_1;
        private System.Windows.Forms.Panel panel_simple_move;
        private System.Windows.Forms.Label label_motion_move_rel;
        private System.Windows.Forms.Label label_motion_move_abs;
        private ACSMotion.Control.ToggleButton toggle_move;
        private System.Windows.Forms.Panel panel_wdi;
        private System.Windows.Forms.Button button_wdi_move_stop;
        private System.Windows.Forms.Button button_wdi_move_down;
        private System.Windows.Forms.Button button_wdi_move_up;
        private System.Windows.Forms.TextBox textBox_wdi_pitch;
        private System.Windows.Forms.TextBox textBox_wdi_current_pos;
        private System.Windows.Forms.Button button_wdi_home;
        private System.Windows.Forms.Button button_wdi_connect;
        private System.Windows.Forms.Label label_wdi_set_high;
        private System.Windows.Forms.Label label_wdi_set_lower;
        private System.Windows.Forms.Label label_wdi_step;
        private System.Windows.Forms.TextBox textBox_wdi_set_high;
        private System.Windows.Forms.TextBox textBox_wdi_set_low;
        private System.Windows.Forms.Button button_wdi_set_high;
        private System.Windows.Forms.Button button_wdi_set_low;
        private System.Windows.Forms.TextBox textBox_wdi_step;
        private System.Windows.Forms.ComboBox comboBox_wdi_image_split;
        private System.Windows.Forms.Label label_wdi_image_split;
        private System.Windows.Forms.Label label_motion_preset_t;
        private System.Windows.Forms.Label label_motion_preset_y;
        private System.Windows.Forms.TextBox textBox_motion_preset_pos_t;
        private System.Windows.Forms.Label label_motion_preset_x;
        private System.Windows.Forms.Label label_simple_move_input;
        private System.Windows.Forms.Label label_simple_move_speed;
        private System.Windows.Forms.Label label_simple_move_actual;
        private System.Windows.Forms.Label label_simple_move_command;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_result;
        private System.Windows.Forms.Button button_process_start;
        private System.Windows.Forms.Button button_process_stop;
        private System.Windows.Forms.Button button_motion_preset_move;
        private System.Windows.Forms.Button button_motion_preset_cancel;
        private System.Windows.Forms.Button button_motion_preset_save;
        private System.Windows.Forms.Button button_motion_stop;
        private System.Windows.Forms.Panel panel_vision_depth;
        private System.Windows.Forms.Button button_vision_depth_connect;
        private System.Windows.Forms.Panel panel_vision_depth_display;
        private System.Windows.Forms.PictureBox pictureBox_colormap;
        private System.Windows.Forms.PictureBox pictureBox_vision_color;
        private System.Windows.Forms.PictureBox pictureBox_vision_merge;
        private System.Windows.Forms.Integration.ElementHost elementHost_vision_3d;
        private System.Windows.Forms.Button button_depth_measure;
        private System.Windows.Forms.Panel panel_measure_width_1;
        private System.Windows.Forms.Panel panel_measure_width_2;
        private System.Windows.Forms.Panel panel_measure_width_3;
        private System.Windows.Forms.Panel panel_measure_height;
        private System.Windows.Forms.Label label_measure_width_1;
        private System.Windows.Forms.Label label_measure_width_2;
        private System.Windows.Forms.Label label_measure_width_3;
        private System.Windows.Forms.Label label_measure_height;
        private System.Windows.Forms.TextBox textBox_measure_width_1;
        private System.Windows.Forms.TextBox textBox_measure_width_2;
        private System.Windows.Forms.TextBox textBox_measure_width_3;
        private System.Windows.Forms.TextBox textBox_measure_height;
        private System.Windows.Forms.Button button_display_change;
        private System.Windows.Forms.PictureBox pictureBox_colormap_2;
        private System.Windows.Forms.TextBox textBox_process_percent;
        private System.Windows.Forms.Panel panel_motion_cycle;
        private System.Windows.Forms.Label label_motion_cycle_move;
        private ACSMotion.Control.ToggleButton toggle_motion_cycle_axis;
        private System.Windows.Forms.Label label_motion_cycle_start_y;
        private System.Windows.Forms.Label label_motion_cycle_start_x;
        private ACSMotion.Control.ToggleButton toggle_motion_cycle_step_method;
        private System.Windows.Forms.Label label_motion_cycle_step_delay;
        private System.Windows.Forms.Label label_motion_cycle_move_delay;
        private System.Windows.Forms.Label label_motion_cycle_step_speed;
        private System.Windows.Forms.Label label_motion_cycle_move_speed;
        private System.Windows.Forms.Label label_motion_cycle_step;
        private System.Windows.Forms.TextBox textBox_motion_cycle_step_delay;
        private System.Windows.Forms.TextBox textBox_motion_cycle_step_max_stroke;
        private System.Windows.Forms.TextBox textBox_motion_cycle_step_speed;
        private System.Windows.Forms.TextBox textBox_motion_cycle_step;
        private System.Windows.Forms.TextBox textBox_motion_cycle_move_delay;
        private System.Windows.Forms.TextBox textBox_motion_cycle_move_speed;
        private System.Windows.Forms.TextBox textBox_motion_cycle_move;
        private System.Windows.Forms.Label label_motion_cycle_axis_y;
        private System.Windows.Forms.Label label_motion_cycle_axis_x;
        private System.Windows.Forms.TextBox textBox_motion_cycle_start_y;
        private System.Windows.Forms.TextBox textBox_motion_cycle_start_x;
        private System.Windows.Forms.Label label_motion_cycle_step_max_stroke;
        private System.Windows.Forms.Label label_motion_cycle_step_method_stroke;
        private System.Windows.Forms.Label label_motion_cycle_step_method_num;
        private System.Windows.Forms.TextBox textBox_motion_cycle_step_num;
        private System.Windows.Forms.Label label_motion_cycle_step_num;
        private System.Windows.Forms.Label label_wdi_pitch;
        private System.Windows.Forms.Button button_motion_preset_laser;
        private System.Windows.Forms.Button button_motion_preset_depth;
        private System.Windows.Forms.Button button_motion_preset_vision;
        private System.Windows.Forms.Button button_motion_cycle_move;
        private System.Windows.Forms.TextBox textBox_number;
    }
}

