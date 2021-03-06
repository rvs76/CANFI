﻿namespace CANFI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_RTL_Frequency = new System.Windows.Forms.Label();
            this.bw_Measure = new System.ComponentModel.BackgroundWorker();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.ssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_Error = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_DUT_Frequency = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_NF = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_Gain = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_MMode = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tt_Main = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_Measure = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Calibrate = new System.Windows.Forms.Button();
            this.lbl_FFT_Filter = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ch_FFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_RTL_Status = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_RTL_P_ON = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_RTL_P_OFF = new System.Windows.Forms.Label();
            this.lbl_RTL_Gain = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gb_FFT_Filter = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Noise = new System.Windows.Forms.Label();
            this.lbl_DUT = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_FFT_Filter_NotchWidth = new System.Windows.Forms.TrackBar();
            this.tb_FFT_Filter_Threshold = new System.Windows.Forms.TrackBar();
            this.ud_Smoothing = new System.Windows.Forms.NumericUpDown();
            this.ud_DUT_P_ENR = new CANFI.CANFIUpDown();
            this.ud_DUT_Frequency = new CANFI.CANFIUpDown();
            this.ud_RTL_P_ENR = new CANFI.CANFIUpDown();
            this.ud_RTL_Frequency = new CANFI.CANFIUpDown();
            this.ss_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_FFT)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gb_FFT_Filter.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FFT_Filter_NotchWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FFT_Filter_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Smoothing)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RTL_Frequency
            // 
            this.lbl_RTL_Frequency.AutoSize = true;
            this.lbl_RTL_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RTL_Frequency.Location = new System.Drawing.Point(2, 25);
            this.lbl_RTL_Frequency.Name = "lbl_RTL_Frequency";
            this.lbl_RTL_Frequency.Size = new System.Drawing.Size(77, 16);
            this.lbl_RTL_Frequency.TabIndex = 28;
            this.lbl_RTL_Frequency.Text = "Freq [MHz]:";
            this.lbl_RTL_Frequency.Click += new System.EventHandler(this.lbl_RTL_Frequency_Click);
            // 
            // bw_Measure
            // 
            this.bw_Measure.WorkerReportsProgress = true;
            this.bw_Measure.WorkerSupportsCancellation = true;
            // 
            // ss_main
            // 
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl_Status,
            this.ssl_Error});
            this.ss_main.Location = new System.Drawing.Point(0, 350);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(794, 22);
            this.ss_main.TabIndex = 44;
            this.ss_main.Text = "statusStrip1";
            // 
            // ssl_Status
            // 
            this.ssl_Status.ActiveLinkColor = System.Drawing.Color.Red;
            this.ssl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssl_Status.Name = "ssl_Status";
            this.ssl_Status.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ssl_Status.Size = new System.Drawing.Size(779, 17);
            this.ssl_Status.Spring = true;
            this.ssl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssl_Error
            // 
            this.ssl_Error.BackColor = System.Drawing.Color.Red;
            this.ssl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssl_Error.ForeColor = System.Drawing.Color.White;
            this.ssl_Error.Name = "ssl_Error";
            this.ssl_Error.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_RTL_P_ENR);
            this.groupBox2.Controls.Add(this.ud_RTL_Frequency);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.lbl_RTL_Frequency);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(100, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 113);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measure Device";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(2, 76);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(81, 16);
            this.label40.TabIndex = 64;
            this.label40.Text = "P_ENR[dB]:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_DUT_Frequency);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lbl_NF);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbl_Gain);
            this.groupBox3.Location = new System.Drawing.Point(99, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 115);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Frequency DUT [MHz]";
            // 
            // lbl_DUT_Frequency
            // 
            this.lbl_DUT_Frequency.BackColor = System.Drawing.Color.Black;
            this.lbl_DUT_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DUT_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DUT_Frequency.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_DUT_Frequency.Location = new System.Drawing.Point(8, 34);
            this.lbl_DUT_Frequency.Name = "lbl_DUT_Frequency";
            this.lbl_DUT_Frequency.Size = new System.Drawing.Size(295, 66);
            this.lbl_DUT_Frequency.TabIndex = 58;
            this.lbl_DUT_Frequency.Text = "00000.000";
            this.lbl_DUT_Frequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(490, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 25);
            this.label14.TabIndex = 50;
            this.label14.Text = "Noise Figure [dB]";
            // 
            // lbl_NF
            // 
            this.lbl_NF.BackColor = System.Drawing.Color.Black;
            this.lbl_NF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NF.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NF.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_NF.Location = new System.Drawing.Point(495, 34);
            this.lbl_NF.Name = "lbl_NF";
            this.lbl_NF.Size = new System.Drawing.Size(180, 66);
            this.lbl_NF.TabIndex = 49;
            this.lbl_NF.Text = "00.00";
            this.lbl_NF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(307, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "Gain [dB]";
            // 
            // lbl_Gain
            // 
            this.lbl_Gain.BackColor = System.Drawing.Color.Black;
            this.lbl_Gain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gain.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_Gain.Location = new System.Drawing.Point(309, 34);
            this.lbl_Gain.Name = "lbl_Gain";
            this.lbl_Gain.Size = new System.Drawing.Size(180, 66);
            this.lbl_Gain.TabIndex = 47;
            this.lbl_Gain.Text = "00.00";
            this.lbl_Gain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_MMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 57);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // cbb_MMode
            // 
            this.cbb_MMode.BackColor = System.Drawing.Color.Black;
            this.cbb_MMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_MMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MMode.ForeColor = System.Drawing.Color.Gold;
            this.cbb_MMode.Location = new System.Drawing.Point(8, 18);
            this.cbb_MMode.Name = "cbb_MMode";
            this.cbb_MMode.Size = new System.Drawing.Size(59, 28);
            this.cbb_MMode.TabIndex = 51;
            this.cbb_MMode.DropDown += new System.EventHandler(this.cbb_MMode_DropDown);
            this.cbb_MMode.SelectedIndexChanged += new System.EventHandler(this.cbb_MMode_SelectedIndexChanged);
            this.cbb_MMode.DropDownClosed += new System.EventHandler(this.cbb_MMode_DropDownClosed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ud_DUT_P_ENR);
            this.groupBox4.Controls.Add(this.ud_DUT_Frequency);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(361, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 114);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device Under Test";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(3, 77);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(81, 16);
            this.label41.TabIndex = 66;
            this.label41.Text = "P_ENR[dB]:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(4, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(77, 16);
            this.label34.TabIndex = 28;
            this.label34.Text = "Freq [MHz]:";
            // 
            // tt_Main
            // 
            this.tt_Main.ShowAlways = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_Measure);
            this.groupBox7.Controls.Add(this.btn_Settings);
            this.groupBox7.Controls.Add(this.btn_Calibrate);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(599, 124);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(181, 113);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Measure";
            this.tt_Main.SetToolTip(this.groupBox7, "Measure Noise Figure without Calibration\r\nMeasure Noise Figure and Gain with Cali" +
                    "bration");
            // 
            // btn_Measure
            // 
            this.btn_Measure.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Measure.Location = new System.Drawing.Point(6, 64);
            this.btn_Measure.Name = "btn_Measure";
            this.btn_Measure.Size = new System.Drawing.Size(92, 37);
            this.btn_Measure.TabIndex = 52;
            this.btn_Measure.Text = "Measure";
            this.btn_Measure.UseVisualStyleBackColor = false;
            this.btn_Measure.Click += new System.EventHandler(this.btn_Measure_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(105, 15);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(69, 86);
            this.btn_Settings.TabIndex = 53;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Calibrate
            // 
            this.btn_Calibrate.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Calibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calibrate.Location = new System.Drawing.Point(6, 15);
            this.btn_Calibrate.Name = "btn_Calibrate";
            this.btn_Calibrate.Size = new System.Drawing.Size(92, 38);
            this.btn_Calibrate.TabIndex = 54;
            this.btn_Calibrate.Text = "Calibrate";
            this.btn_Calibrate.UseVisualStyleBackColor = false;
            this.btn_Calibrate.Click += new System.EventHandler(this.btn_Calibrate_Click);
            // 
            // lbl_FFT_Filter
            // 
            this.lbl_FFT_Filter.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_FFT_Filter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_FFT_Filter.Location = new System.Drawing.Point(13, 19);
            this.lbl_FFT_Filter.Name = "lbl_FFT_Filter";
            this.lbl_FFT_Filter.Size = new System.Drawing.Size(60, 8);
            this.lbl_FFT_Filter.TabIndex = 55;
            this.tt_Main.SetToolTip(this.lbl_FFT_Filter, "Click here to enable/disable FFT-Filter");
            this.lbl_FFT_Filter.Click += new System.EventHandler(this.lbl_FFT_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ch_FFT);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(99, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(681, 103);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SDR Values";
            // 
            // ch_FFT
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "Main";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.ch_FFT.ChartAreas.Add(chartArea1);
            this.ch_FFT.Location = new System.Drawing.Point(154, 19);
            this.ch_FFT.Name = "ch_FFT";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "Main";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "FFT";
            this.ch_FFT.Series.Add(series1);
            this.ch_FFT.Size = new System.Drawing.Size(520, 78);
            this.ch_FFT.TabIndex = 70;
            this.ch_FFT.Text = "FFT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_RTL_Status);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lbl_RTL_P_ON);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_RTL_P_OFF);
            this.panel1.Controls.Add(this.lbl_RTL_Gain);
            this.panel1.Location = new System.Drawing.Point(8, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 77);
            this.panel1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Status:";
            // 
            // lbl_RTL_Status
            // 
            this.lbl_RTL_Status.AutoSize = true;
            this.lbl_RTL_Status.BackColor = System.Drawing.Color.Black;
            this.lbl_RTL_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RTL_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_RTL_Status.Location = new System.Drawing.Point(62, 57);
            this.lbl_RTL_Status.Name = "lbl_RTL_Status";
            this.lbl_RTL_Status.Size = new System.Drawing.Size(54, 16);
            this.lbl_RTL_Status.TabIndex = 70;
            this.lbl_RTL_Status.Text = "Invalid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(110, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "dB";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(110, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 16);
            this.label22.TabIndex = 69;
            this.label22.Text = "dB";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gold;
            this.label24.Location = new System.Drawing.Point(110, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 16);
            this.label24.TabIndex = 68;
            this.label24.Text = "dB";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Black;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Gold;
            this.label23.Location = new System.Drawing.Point(6, 2);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 16);
            this.label23.TabIndex = 63;
            this.label23.Text = "Gain:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gold;
            this.label20.Location = new System.Drawing.Point(6, 20);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 16);
            this.label20.TabIndex = 62;
            this.label20.Text = "P_ON:";
            // 
            // lbl_RTL_P_ON
            // 
            this.lbl_RTL_P_ON.AutoSize = true;
            this.lbl_RTL_P_ON.BackColor = System.Drawing.Color.Black;
            this.lbl_RTL_P_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RTL_P_ON.ForeColor = System.Drawing.Color.Gold;
            this.lbl_RTL_P_ON.Location = new System.Drawing.Point(63, 20);
            this.lbl_RTL_P_ON.Name = "lbl_RTL_P_ON";
            this.lbl_RTL_P_ON.Size = new System.Drawing.Size(36, 16);
            this.lbl_RTL_P_ON.TabIndex = 61;
            this.lbl_RTL_P_ON.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "P_OFF:";
            // 
            // lbl_RTL_P_OFF
            // 
            this.lbl_RTL_P_OFF.AutoSize = true;
            this.lbl_RTL_P_OFF.BackColor = System.Drawing.Color.Black;
            this.lbl_RTL_P_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RTL_P_OFF.ForeColor = System.Drawing.Color.Gold;
            this.lbl_RTL_P_OFF.Location = new System.Drawing.Point(63, 39);
            this.lbl_RTL_P_OFF.Name = "lbl_RTL_P_OFF";
            this.lbl_RTL_P_OFF.Size = new System.Drawing.Size(36, 16);
            this.lbl_RTL_P_OFF.TabIndex = 65;
            this.lbl_RTL_P_OFF.Text = "0.00";
            // 
            // lbl_RTL_Gain
            // 
            this.lbl_RTL_Gain.AutoSize = true;
            this.lbl_RTL_Gain.BackColor = System.Drawing.Color.Black;
            this.lbl_RTL_Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RTL_Gain.ForeColor = System.Drawing.Color.Gold;
            this.lbl_RTL_Gain.Location = new System.Drawing.Point(63, 2);
            this.lbl_RTL_Gain.Name = "lbl_RTL_Gain";
            this.lbl_RTL_Gain.Size = new System.Drawing.Size(36, 16);
            this.lbl_RTL_Gain.TabIndex = 64;
            this.lbl_RTL_Gain.Text = "0.00";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ud_Smoothing);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(82, 58);
            this.groupBox6.TabIndex = 53;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Smooth";
            // 
            // gb_FFT_Filter
            // 
            this.gb_FFT_Filter.Controls.Add(this.label4);
            this.gb_FFT_Filter.Controls.Add(this.label1);
            this.gb_FFT_Filter.Controls.Add(this.tb_FFT_Filter_NotchWidth);
            this.gb_FFT_Filter.Controls.Add(this.tb_FFT_Filter_Threshold);
            this.gb_FFT_Filter.Controls.Add(this.lbl_FFT_Filter);
            this.gb_FFT_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_FFT_Filter.Location = new System.Drawing.Point(12, 244);
            this.gb_FFT_Filter.Name = "gb_FFT_Filter";
            this.gb_FFT_Filter.Size = new System.Drawing.Size(82, 103);
            this.gb_FFT_Filter.TabIndex = 60;
            this.gb_FFT_Filter.TabStop = false;
            this.gb_FFT_Filter.Text = "FFT-Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 9);
            this.label4.TabIndex = 71;
            this.label4.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 9);
            this.label1.TabIndex = 68;
            this.label1.Text = "Threshold";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.lbl_Noise);
            this.groupBox8.Controls.Add(this.lbl_DUT);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Location = new System.Drawing.Point(12, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(82, 115);
            this.groupBox8.TabIndex = 61;
            this.groupBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "ENR:";
            // 
            // lbl_Noise
            // 
            this.lbl_Noise.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_Noise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Noise.Location = new System.Drawing.Point(49, 40);
            this.lbl_Noise.Name = "lbl_Noise";
            this.lbl_Noise.Size = new System.Drawing.Size(18, 19);
            this.lbl_Noise.TabIndex = 61;
            // 
            // lbl_DUT
            // 
            this.lbl_DUT.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_DUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DUT.Location = new System.Drawing.Point(49, 74);
            this.lbl_DUT.Name = "lbl_DUT";
            this.lbl_DUT.Size = new System.Drawing.Size(18, 19);
            this.lbl_DUT.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "DUT:";
            // 
            // tb_FFT_Filter_NotchWidth
            // 
            this.tb_FFT_Filter_NotchWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "FFT_Filter_NotchWidth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_FFT_Filter_NotchWidth.Location = new System.Drawing.Point(43, 30);
            this.tb_FFT_Filter_NotchWidth.Maximum = 16384;
            this.tb_FFT_Filter_NotchWidth.Name = "tb_FFT_Filter_NotchWidth";
            this.tb_FFT_Filter_NotchWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_FFT_Filter_NotchWidth.Size = new System.Drawing.Size(45, 60);
            this.tb_FFT_Filter_NotchWidth.TabIndex = 70;
            this.tb_FFT_Filter_NotchWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_FFT_Filter_NotchWidth.Value = global::CANFI.Properties.Settings.Default.FFT_Filter_NotchWidth;
            this.tb_FFT_Filter_NotchWidth.Scroll += new System.EventHandler(this.tb_FFT_Filter_NotchWidth_Scroll);
            // 
            // tb_FFT_Filter_Threshold
            // 
            this.tb_FFT_Filter_Threshold.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "FFT_Filter_Threshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_FFT_Filter_Threshold.Location = new System.Drawing.Point(15, 32);
            this.tb_FFT_Filter_Threshold.Maximum = 100;
            this.tb_FFT_Filter_Threshold.Minimum = 1;
            this.tb_FFT_Filter_Threshold.Name = "tb_FFT_Filter_Threshold";
            this.tb_FFT_Filter_Threshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_FFT_Filter_Threshold.Size = new System.Drawing.Size(45, 60);
            this.tb_FFT_Filter_Threshold.TabIndex = 68;
            this.tb_FFT_Filter_Threshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_FFT_Filter_Threshold.Value = global::CANFI.Properties.Settings.Default.FFT_Filter_Threshold;
            this.tb_FFT_Filter_Threshold.Scroll += new System.EventHandler(this.tb_FFT_Filter_Threshold_Scroll);
            // 
            // ud_Smoothing
            // 
            this.ud_Smoothing.BackColor = System.Drawing.Color.Black;
            this.ud_Smoothing.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "Smoothing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_Smoothing.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", global::CANFI.Properties.Settings.Default, "Smoothing_Max", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_Smoothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_Smoothing.ForeColor = System.Drawing.Color.Chartreuse;
            this.ud_Smoothing.Location = new System.Drawing.Point(8, 19);
            this.ud_Smoothing.Maximum = global::CANFI.Properties.Settings.Default.Smoothing_Max;
            this.ud_Smoothing.Minimum = global::CANFI.Properties.Settings.Default.Smoothing_Min;
            this.ud_Smoothing.Name = "ud_Smoothing";
            this.ud_Smoothing.Size = new System.Drawing.Size(59, 29);
            this.ud_Smoothing.TabIndex = 60;
            this.tt_Main.SetToolTip(this.ud_Smoothing, "Select the Smoothing Level here.\r\nSmoothing is done by a Moving Avarage of 2^[Smo" +
                    "othing Level] values.");
            this.ud_Smoothing.Value = global::CANFI.Properties.Settings.Default.Smoothing;
            this.ud_Smoothing.ValueChanged += new System.EventHandler(this.ud_Smoothing_ValueChanged);
            // 
            // ud_DUT_P_ENR
            // 
            this.ud_DUT_P_ENR.BackColor = System.Drawing.Color.Black;
            this.ud_DUT_P_ENR.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "RTL_P_ENR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_DUT_P_ENR.DecimalPlaces = 2;
            this.ud_DUT_P_ENR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_DUT_P_ENR.ForeColor = System.Drawing.Color.Chartreuse;
            this.ud_DUT_P_ENR.Location = new System.Drawing.Point(84, 67);
            this.ud_DUT_P_ENR.Multiline = false;
            this.ud_DUT_P_ENR.Name = "ud_DUT_P_ENR";
            this.ud_DUT_P_ENR.PredecimalPlaces = 2;
            this.ud_DUT_P_ENR.ReadOnly = true;
            this.ud_DUT_P_ENR.ShortcutsEnabled = false;
            this.ud_DUT_P_ENR.Size = new System.Drawing.Size(140, 37);
            this.ud_DUT_P_ENR.TabIndex = 67;
            this.ud_DUT_P_ENR.Text = "0.015 ";
            this.tt_Main.SetToolTip(this.ud_DUT_P_ENR, "Use Left+Right to select\r\nUse Up+Dn or Mouse Wheel to change value");
            this.ud_DUT_P_ENR.Value = global::CANFI.Properties.Settings.Default.RTL_P_ENR;
            // 
            // ud_DUT_Frequency
            // 
            this.ud_DUT_Frequency.BackColor = System.Drawing.Color.Black;
            this.ud_DUT_Frequency.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "DUT_Frequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_DUT_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_DUT_Frequency.ForeColor = System.Drawing.Color.Chartreuse;
            this.ud_DUT_Frequency.Location = new System.Drawing.Point(84, 18);
            this.ud_DUT_Frequency.Multiline = false;
            this.ud_DUT_Frequency.Name = "ud_DUT_Frequency";
            this.ud_DUT_Frequency.PredecimalPlaces = 5;
            this.ud_DUT_Frequency.ReadOnly = true;
            this.ud_DUT_Frequency.ShortcutsEnabled = false;
            this.ud_DUT_Frequency.Size = new System.Drawing.Size(140, 37);
            this.ud_DUT_Frequency.TabIndex = 65;
            this.ud_DUT_Frequency.Text = "00.000.144 ";
            this.tt_Main.SetToolTip(this.ud_DUT_Frequency, "Use Left+Right to select\r\nUse Up+Dn or Mouse Wheel to change value");
            this.ud_DUT_Frequency.Value = global::CANFI.Properties.Settings.Default.DUT_Frequency;
            this.ud_DUT_Frequency.ValueChanged += new System.EventHandler(this.ud_DUT_Frequency_ValueChanged);
            // 
            // ud_RTL_P_ENR
            // 
            this.ud_RTL_P_ENR.BackColor = System.Drawing.Color.Black;
            this.ud_RTL_P_ENR.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "RTL_P_ENR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_RTL_P_ENR.DecimalPlaces = 2;
            this.ud_RTL_P_ENR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_RTL_P_ENR.ForeColor = System.Drawing.Color.Chartreuse;
            this.ud_RTL_P_ENR.Location = new System.Drawing.Point(82, 64);
            this.ud_RTL_P_ENR.Multiline = false;
            this.ud_RTL_P_ENR.Name = "ud_RTL_P_ENR";
            this.ud_RTL_P_ENR.PredecimalPlaces = 2;
            this.ud_RTL_P_ENR.ReadOnly = true;
            this.ud_RTL_P_ENR.ShortcutsEnabled = false;
            this.ud_RTL_P_ENR.Size = new System.Drawing.Size(140, 37);
            this.ud_RTL_P_ENR.TabIndex = 65;
            this.ud_RTL_P_ENR.Text = "0.015 ";
            this.tt_Main.SetToolTip(this.ud_RTL_P_ENR, "Use Left+Right to select\r\nUse Up+Dn or Mouse Wheel to change value");
            this.ud_RTL_P_ENR.Value = global::CANFI.Properties.Settings.Default.RTL_P_ENR;
            // 
            // ud_RTL_Frequency
            // 
            this.ud_RTL_Frequency.BackColor = System.Drawing.Color.Black;
            this.ud_RTL_Frequency.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::CANFI.Properties.Settings.Default, "RTL_Frequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ud_RTL_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_RTL_Frequency.ForeColor = System.Drawing.Color.Chartreuse;
            this.ud_RTL_Frequency.Location = new System.Drawing.Point(82, 15);
            this.ud_RTL_Frequency.Multiline = false;
            this.ud_RTL_Frequency.Name = "ud_RTL_Frequency";
            this.ud_RTL_Frequency.PredecimalPlaces = 5;
            this.ud_RTL_Frequency.ReadOnly = true;
            this.ud_RTL_Frequency.ShortcutsEnabled = false;
            this.ud_RTL_Frequency.Size = new System.Drawing.Size(140, 37);
            this.ud_RTL_Frequency.TabIndex = 53;
            this.ud_RTL_Frequency.Text = "00.000.144 ";
            this.tt_Main.SetToolTip(this.ud_RTL_Frequency, "Use Left+Right to select\r\nUse Up+Dn or Mouse Wheel to change value");
            this.ud_RTL_Frequency.Value = global::CANFI.Properties.Settings.Default.RTL_Frequency;
            this.ud_RTL_Frequency.ValueChanged += new System.EventHandler(this.ud_RTL_Frequency_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 372);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.gb_FFT_Filter);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ss_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CANFI#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_FFT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.gb_FFT_Filter.ResumeLayout(false);
            this.gb_FFT_Filter.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FFT_Filter_NotchWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FFT_Filter_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Smoothing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RTL_Frequency;
        private System.ComponentModel.BackgroundWorker bw_Measure;
        private System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.ToolStripStatusLabel ssl_Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Gain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_NF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripStatusLabel ssl_Error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cbb_MMode;
        private System.Windows.Forms.ToolTip tt_Main;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_RTL_P_ON;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_RTL_P_OFF;
        private System.Windows.Forms.Label lbl_RTL_Gain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_RTL_Status;
        private CANFIUpDown ud_RTL_Frequency;
        private CANFIUpDown ud_DUT_Frequency;
        private CANFIUpDown ud_RTL_P_ENR;
        private CANFIUpDown ud_DUT_P_ENR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DUT_Frequency;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown ud_Smoothing;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_Calibrate;
        private System.Windows.Forms.Button btn_Measure;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_FFT;
        private System.Windows.Forms.Label lbl_FFT_Filter;
        private System.Windows.Forms.TrackBar tb_FFT_Filter_Threshold;
        private System.Windows.Forms.GroupBox gb_FFT_Filter;
        private System.Windows.Forms.TrackBar tb_FFT_Filter_NotchWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Noise;
        private System.Windows.Forms.Label lbl_DUT;
        private System.Windows.Forms.Label label17;
    }
}

