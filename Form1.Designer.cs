﻿
namespace Project_1_20202
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Conn_Disconn_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SampBTN = new System.Windows.Forms.Button();
            this.Selec = new System.Windows.Forms.RadioButton();
            this.Cont = new System.Windows.Forms.RadioButton();
            this.Run_Time = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_Path = new System.Windows.Forms.RichTextBox();
            this.Temp_Box = new System.Windows.Forms.RichTextBox();
            this.Save_Data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgBar2 = new System.Windows.Forms.ProgressBar();
            this.Run_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.COM_BOX = new System.Windows.Forms.ComboBox();
            this.ProgBar1 = new System.Windows.Forms.ProgressBar();
            this.Data_Table = new System.Windows.Forms.DataGridView();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Node = new System.Windows.Forms.RichTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Conn_Disconn_Button
            // 
            this.Conn_Disconn_Button.Location = new System.Drawing.Point(8, 58);
            this.Conn_Disconn_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Conn_Disconn_Button.Name = "Conn_Disconn_Button";
            this.Conn_Disconn_Button.Size = new System.Drawing.Size(135, 41);
            this.Conn_Disconn_Button.TabIndex = 0;
            this.Conn_Disconn_Button.Text = "Connect";
            this.Conn_Disconn_Button.UseVisualStyleBackColor = true;
            this.Conn_Disconn_Button.Click += new System.EventHandler(this.Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Node);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.SampBTN);
            this.groupBox1.Controls.Add(this.Selec);
            this.groupBox1.Controls.Add(this.Cont);
            this.groupBox1.Controls.Add(this.Run_Time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Save_Path);
            this.groupBox1.Controls.Add(this.Temp_Box);
            this.groupBox1.Controls.Add(this.Save_Data);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProgBar2);
            this.groupBox1.Controls.Add(this.Run_Button);
            this.groupBox1.Controls.Add(this.Save_Button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COM_BOX);
            this.groupBox1.Controls.Add(this.ProgBar1);
            this.groupBox1.Controls.Add(this.Conn_Disconn_Button);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(388, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect and Control";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(187, 23);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(23, 24);
            this.R.TabIndex = 22;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(244, 107);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(136, 40);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SampBTN
            // 
            this.SampBTN.Location = new System.Drawing.Point(244, 162);
            this.SampBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SampBTN.Name = "SampBTN";
            this.SampBTN.Size = new System.Drawing.Size(136, 40);
            this.SampBTN.TabIndex = 18;
            this.SampBTN.Text = "Sample";
            this.SampBTN.UseVisualStyleBackColor = true;
            this.SampBTN.Click += new System.EventHandler(this.SampBTN_Click);
            // 
            // Selec
            // 
            this.Selec.AutoSize = true;
            this.Selec.Location = new System.Drawing.Point(199, 218);
            this.Selec.Name = "Selec";
            this.Selec.Size = new System.Drawing.Size(86, 21);
            this.Selec.TabIndex = 17;
            this.Selec.TabStop = true;
            this.Selec.Text = "Selective";
            this.Selec.UseVisualStyleBackColor = true;
            // 
            // Cont
            // 
            this.Cont.AutoSize = true;
            this.Cont.Location = new System.Drawing.Point(43, 218);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(100, 21);
            this.Cont.TabIndex = 16;
            this.Cont.TabStop = true;
            this.Cont.Text = "Continuous";
            this.Cont.UseVisualStyleBackColor = true;
            // 
            // Run_Time
            // 
            this.Run_Time.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_Time.Location = new System.Drawing.Point(286, 23);
            this.Run_Time.Margin = new System.Windows.Forms.Padding(4);
            this.Run_Time.Multiline = false;
            this.Run_Time.Name = "Run_Time";
            this.Run_Time.ReadOnly = true;
            this.Run_Time.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Run_Time.ShortcutsEnabled = false;
            this.Run_Time.Size = new System.Drawing.Size(94, 24);
            this.Run_Time.TabIndex = 15;
            this.Run_Time.TabStop = false;
            this.Run_Time.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Temperature:";
            // 
            // Save_Path
            // 
            this.Save_Path.Location = new System.Drawing.Point(92, 246);
            this.Save_Path.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Path.Name = "Save_Path";
            this.Save_Path.Size = new System.Drawing.Size(288, 22);
            this.Save_Path.TabIndex = 13;
            this.Save_Path.Text = "";
            // 
            // Temp_Box
            // 
            this.Temp_Box.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp_Box.Location = new System.Drawing.Point(105, 107);
            this.Temp_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Temp_Box.Multiline = false;
            this.Temp_Box.Name = "Temp_Box";
            this.Temp_Box.ReadOnly = true;
            this.Temp_Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Temp_Box.ShortcutsEnabled = false;
            this.Temp_Box.Size = new System.Drawing.Size(131, 40);
            this.Temp_Box.TabIndex = 12;
            this.Temp_Box.TabStop = false;
            this.Temp_Box.Text = "";
            // 
            // Save_Data
            // 
            this.Save_Data.Location = new System.Drawing.Point(8, 276);
            this.Save_Data.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(165, 41);
            this.Save_Data.TabIndex = 11;
            this.Save_Data.Text = "Save File Excel";
            this.Save_Data.UseVisualStyleBackColor = true;
            this.Save_Data.Click += new System.EventHandler(this.Save_File_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Run time:";
            // 
            // ProgBar2
            // 
            this.ProgBar2.BackColor = System.Drawing.SystemColors.Control;
            this.ProgBar2.ForeColor = System.Drawing.Color.Red;
            this.ProgBar2.Location = new System.Drawing.Point(341, 58);
            this.ProgBar2.Margin = new System.Windows.Forms.Padding(4);
            this.ProgBar2.Name = "ProgBar2";
            this.ProgBar2.Size = new System.Drawing.Size(39, 41);
            this.ProgBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBar2.TabIndex = 6;
            // 
            // Run_Button
            // 
            this.Run_Button.Location = new System.Drawing.Point(199, 58);
            this.Run_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(135, 41);
            this.Run_Button.TabIndex = 5;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(199, 276);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(181, 41);
            this.Save_Button.TabIndex = 4;
            this.Save_Button.Text = "Exit";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT:";
            // 
            // COM_BOX
            // 
            this.COM_BOX.FormattingEnabled = true;
            this.COM_BOX.Location = new System.Drawing.Point(102, 23);
            this.COM_BOX.Margin = new System.Windows.Forms.Padding(4);
            this.COM_BOX.Name = "COM_BOX";
            this.COM_BOX.Size = new System.Drawing.Size(78, 24);
            this.COM_BOX.TabIndex = 2;
            // 
            // ProgBar1
            // 
            this.ProgBar1.BackColor = System.Drawing.SystemColors.Control;
            this.ProgBar1.ForeColor = System.Drawing.Color.Red;
            this.ProgBar1.Location = new System.Drawing.Point(151, 58);
            this.ProgBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ProgBar1.Name = "ProgBar1";
            this.ProgBar1.Size = new System.Drawing.Size(39, 41);
            this.ProgBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBar1.TabIndex = 1;
            // 
            // Data_Table
            // 
            this.Data_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Data_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Table.DefaultCellStyle = dataGridViewCellStyle18;
            this.Data_Table.Location = new System.Drawing.Point(16, 363);
            this.Data_Table.Margin = new System.Windows.Forms.Padding(4);
            this.Data_Table.Name = "Data_Table";
            this.Data_Table.RowHeadersVisible = false;
            this.Data_Table.RowHeadersWidth = 51;
            this.Data_Table.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Data_Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Table.RowTemplate.DefaultCellStyle.Format = "N1";
            this.Data_Table.RowTemplate.DefaultCellStyle.NullValue = null;
            this.Data_Table.RowTemplate.Height = 25;
            this.Data_Table.RowTemplate.ReadOnly = true;
            this.Data_Table.Size = new System.Drawing.Size(388, 125);
            this.Data_Table.TabIndex = 2;
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarksNextToAxis = false;
            chartArea2.AxisX.LabelStyle.Interval = 5D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Interval = 5D;
            chartArea2.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea2.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.Interval = 1D;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.Title = "Time (s)";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.IsMarksNextToAxis = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorTickMark.Interval = 1D;
            chartArea2.AxisX2.MajorTickMark.Size = 2F;
            chartArea2.AxisX2.MinorTickMark.Enabled = true;
            chartArea2.AxisX2.MinorTickMark.Interval = 0.2D;
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsMarksNextToAxis = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Interval = 20D;
            chartArea2.AxisY.MajorTickMark.Size = 2F;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.Interval = 5D;
            chartArea2.AxisY.ScaleView.MinSize = 5D;
            chartArea2.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.Title = "Temperature (C)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Interval = 10D;
            chartArea2.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY2.IsMarksNextToAxis = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorTickMark.Interval = 20D;
            chartArea2.AxisY2.MajorTickMark.Size = 2F;
            chartArea2.AxisY2.MinorTickMark.Enabled = true;
            chartArea2.AxisY2.MinorTickMark.Interval = 5D;
            chartArea2.AxisY2.ScaleView.MinSize = 5D;
            chartArea2.AxisY2.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY2.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(413, 30);
            this.Chart.Margin = new System.Windows.Forms.Padding(4);
            this.Chart.Name = "Chart";
            this.Chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Temperature1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series8.Name = "Temperature2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series9.Name = "Temperature3";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series10.Name = "Temperature4";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series11.Name = "Temperature5";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series12.Name = "Temperature6";
            this.Chart.Series.Add(series7);
            this.Chart.Series.Add(series8);
            this.Chart.Series.Add(series9);
            this.Chart.Series.Add(series10);
            this.Chart.Series.Add(series11);
            this.Chart.Series.Add(series12);
            this.Chart.Size = new System.Drawing.Size(808, 458);
            this.Chart.TabIndex = 3;
            this.Chart.Text = "Chart";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "title1";
            title2.Text = "Temperature vs. Time";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.Chart.Titles.Add(title2);
            // 
            // Serial_Port
            // 
            this.Serial_Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_Port_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Project_1_20202.Properties.Resources.Logo_Hust2;
            this.pictureBox1.Location = new System.Drawing.Point(1228, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1228, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Node:";
            // 
            // Node
            // 
            this.Node.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Node.Location = new System.Drawing.Point(105, 162);
            this.Node.Margin = new System.Windows.Forms.Padding(4);
            this.Node.Multiline = false;
            this.Node.Name = "Node";
            this.Node.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Node.ShortcutsEnabled = false;
            this.Node.Size = new System.Drawing.Size(38, 40);
            this.Node.TabIndex = 24;
            this.Node.TabStop = false;
            this.Node.Text = "";
            // 
            // Column1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column1.HeaderText = "Time (s)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column2.HeaderText = "Temperture 1 (C)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column3.HeaderText = "Temperture 2 (C)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column4.HeaderText = "Temperture 3 (C)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column5.HeaderText = "Temperture 4 (C)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Column6.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column6.HeaderText = "Temperture 5 (C)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Column7.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column7.HeaderText = "Temperture 6 (C)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1348, 502);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Data_Table);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Temperture_Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Conn_Disconn_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COM_BOX;
        private System.Windows.Forms.ProgressBar ProgBar1;
        private System.Windows.Forms.DataGridView Data_Table;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.IO.Ports.SerialPort Serial_Port;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.ProgressBar ProgBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_Data;
        private System.Windows.Forms.RichTextBox Save_Path;
        private System.Windows.Forms.RichTextBox Temp_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Run_Time;
        private System.Windows.Forms.Button SampBTN;
        private System.Windows.Forms.RadioButton Selec;
        private System.Windows.Forms.RadioButton Cont;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.RichTextBox Node;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

