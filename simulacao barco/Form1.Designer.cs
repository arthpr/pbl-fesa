namespace simulacao_barco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador - Movimento de Travessia de um Barco\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura L do rio (m)\r\n";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDown1.Location = new System.Drawing.Point(363, 112);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocidade do barco (m/s)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDown2.Location = new System.Drawing.Point(363, 166);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Velocidade da correnteza (m/s)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDown3.Location = new System.Drawing.Point(363, 225);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ângulo de inclinação θ";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(363, 279);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            159,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(160, 26);
            this.numericUpDown4.TabIndex = 8;
            this.numericUpDown4.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(363, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(160, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "ver gráficos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 538);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 28);
            this.label7.TabIndex = 11;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.RoyalBlue;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle5;
            chartArea1.AxisX.LabelStyle.Format = "F1";
            chartArea1.AxisX.Title = "t (s)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "F1";
            chartArea1.AxisY.Title = "Sx (m)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.LabelStyle.Format = "F1";
            chartArea2.AxisX.Title = "t (s)";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LabelStyle.Format = "F1";
            chartArea2.AxisY.Title = "Sy (m)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(565, 105);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.RoyalBlue;
            series1.LabelFormat = "F1";
            series1.Legend = "Legend1";
            series1.LegendText = "Distância horizontal";
            series1.MarkerColor = System.Drawing.Color.RoyalBlue;
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.OrangeRed;
            series2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            series2.LabelForeColor = System.Drawing.Color.OrangeRed;
            series2.LabelFormat = "F1";
            series2.Legend = "Legend1";
            series2.LegendText = "Distância vertical";
            series2.MarkerColor = System.Drawing.Color.OrangeRed;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(787, 615);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gráficos S(t)";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(36, 647);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 28);
            this.label8.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(363, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "ver animação";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.LightGreen;
            this.chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Shingle;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.LimeGreen;
            this.chart2.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Shingle;
            this.chart2.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin3;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LabelStyle.Format = "F1";
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LabelStyle.Format = "F1";
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            chartArea3.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Shingle;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.BorderWidth = 2;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 100F;
            chartArea3.InnerPlotPosition.Width = 100F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 90F;
            chartArea3.Position.Width = 90F;
            chartArea3.Position.X = 5F;
            chartArea3.Position.Y = 5F;
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Location = new System.Drawing.Point(565, 103);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerBorderWidth = 2;
            series3.MarkerColor = System.Drawing.Color.OrangeRed;
            series3.MarkerSize = 15;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(787, 615);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.button3.Location = new System.Drawing.Point(41, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "ver histórico";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightYellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(565, 102);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(785, 612);
            this.listBox1.TabIndex = 17;
            this.listBox1.Visible = false;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightYellow;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 482);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(348, 232);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Location = new System.Drawing.Point(451, 690);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "selecionar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(754, 78);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 13, 16, 7, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button5.Location = new System.Drawing.Point(1245, 76);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 26);
            this.button5.TabIndex = 22;
            this.button5.Text = "exibir todos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "data",
            "valor"});
            this.comboBox1.Location = new System.Drawing.Point(650, 77);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(949, 78);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown5.TabIndex = 24;
            this.numericUpDown5.Visible = false;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightBlue;
            this.button6.Location = new System.Drawing.Point(1036, 76);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 26);
            this.button6.TabIndex = 25;
            this.button6.Text = "buscar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "filtrar por";
            this.label9.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Largura L do rio",
            "Velocidade do barco",
            "Velocidade da correnteza",
            "Ângulo de inclinação θ"});
            this.comboBox2.Location = new System.Drawing.Point(755, 77);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 24);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1407, 726);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

