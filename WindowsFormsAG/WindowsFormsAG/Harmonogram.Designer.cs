namespace WindowsFormsAG
{
    partial class Harmonogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenEgzaminy = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenEgzaminatorzy = new System.Windows.Forms.ToolStripMenuItem();
            this.egzaminyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazEgzaminyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egzaminatorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazEgzaminatorowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.dateTimePickerFor = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labeldate = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGeneracji = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bestFitness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileEgzaminy = new System.Windows.Forms.OpenFileDialog();
            this.openFileEgzaminatorzy = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 18);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 28);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Generuj";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.egzaminyToolStripMenuItem,
            this.egzaminatorzyToolStripMenuItem,
            this.algorytmToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenEgzaminy,
            this.miOpenEgzaminatorzy});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "Plik";
            // 
            // miOpenEgzaminy
            // 
            this.miOpenEgzaminy.Name = "miOpenEgzaminy";
            this.miOpenEgzaminy.Size = new System.Drawing.Size(224, 22);
            this.miOpenEgzaminy.Text = "Wczytaj listę egzaminów";
            this.miOpenEgzaminy.Click += new System.EventHandler(this.miOpenEgzaminy_Click);
            // 
            // miOpenEgzaminatorzy
            // 
            this.miOpenEgzaminatorzy.Name = "miOpenEgzaminatorzy";
            this.miOpenEgzaminatorzy.Size = new System.Drawing.Size(224, 22);
            this.miOpenEgzaminatorzy.Text = "Wczytaj listę egzaminatorów";
            this.miOpenEgzaminatorzy.Click += new System.EventHandler(this.miOpenEgzaminatorzy_Click);
            // 
            // egzaminyToolStripMenuItem
            // 
            this.egzaminyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokazEgzaminyToolStripMenuItem});
            this.egzaminyToolStripMenuItem.Name = "egzaminyToolStripMenuItem";
            this.egzaminyToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.egzaminyToolStripMenuItem.Text = "Egzaminy";
            // 
            // pokazEgzaminyToolStripMenuItem
            // 
            this.pokazEgzaminyToolStripMenuItem.Name = "pokazEgzaminyToolStripMenuItem";
            this.pokazEgzaminyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pokazEgzaminyToolStripMenuItem.Text = "Pokaż egzaminy";
            this.pokazEgzaminyToolStripMenuItem.Click += new System.EventHandler(this.pokazEgzaminyToolStripMenuItem_Click);
            // 
            // egzaminatorzyToolStripMenuItem
            // 
            this.egzaminatorzyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokazEgzaminatorowToolStripMenuItem});
            this.egzaminatorzyToolStripMenuItem.Name = "egzaminatorzyToolStripMenuItem";
            this.egzaminatorzyToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.egzaminatorzyToolStripMenuItem.Text = "Egzaminatorzy";
            // 
            // pokazEgzaminatorowToolStripMenuItem
            // 
            this.pokazEgzaminatorowToolStripMenuItem.Name = "pokazEgzaminatorowToolStripMenuItem";
            this.pokazEgzaminatorowToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pokazEgzaminatorowToolStripMenuItem.Text = "Pokaż egzaminatorów";
            this.pokazEgzaminatorowToolStripMenuItem.Click += new System.EventHandler(this.pokazEgzaminatorowToolStripMenuItem_Click);
            // 
            // algorytmToolStripMenuItem
            // 
            this.algorytmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.algorytmToolStripMenuItem.Name = "algorytmToolStripMenuItem";
            this.algorytmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.algorytmToolStripMenuItem.Text = "Algorytm";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.63812F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSchedule, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.39044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.22972F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.37984F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 750);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.dateTimePickerFor);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.labeldate);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(175, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 71);
            this.panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(651, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "LICZBA EGZAMINÓW:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(807, 24);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(15, 16);
            this.labelDay.TabIndex = 35;
            this.labelDay.Text = "0";
            // 
            // dateTimePickerFor
            // 
            this.dateTimePickerFor.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFor.Location = new System.Drawing.Point(526, 23);
            this.dateTimePickerFor.Name = "dateTimePickerFor";
            this.dateTimePickerFor.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFor.TabIndex = 34;
            this.dateTimePickerFor.ValueChanged += new System.EventHandler(this.dateTimePickerFor_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(407, 23);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerFrom.TabIndex = 33;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldate.Location = new System.Drawing.Point(186, 23);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(215, 19);
            this.labeldate.TabIndex = 32;
            this.labeldate.Text = "TERMIN SESJI EGZAMINACYJNEJ";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(90, 18);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(88, 28);
            this.buttonStop.TabIndex = 31;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 520);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "NAJLEPSZE WYNIKI";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 486);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wersja";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartości funkcji celu";
            this.columnHeader2.Width = 111;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Title = "Liczba generacji";
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "Dopasowanie";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(175, 606);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Funkcja celu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(875, 141);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // dataGridViewSchedule
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(175, 80);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(875, 520);
            this.dataGridViewSchedule.TabIndex = 3;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellDoubleClick);
            this.dataGridViewSchedule.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewSchedule_CellPainting);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelGeneracji);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 71);
            this.panel3.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "LICZBA GENERACJI";
            // 
            // labelGeneracji
            // 
            this.labelGeneracji.AutoSize = true;
            this.labelGeneracji.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGeneracji.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGeneracji.Location = new System.Drawing.Point(62, 33);
            this.labelGeneracji.Name = "labelGeneracji";
            this.labelGeneracji.Size = new System.Drawing.Size(25, 29);
            this.labelGeneracji.TabIndex = 38;
            this.labelGeneracji.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bestFitness);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 141);
            this.panel4.TabIndex = 37;
            // 
            // bestFitness
            // 
            this.bestFitness.AutoSize = true;
            this.bestFitness.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bestFitness.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bestFitness.Location = new System.Drawing.Point(21, 63);
            this.bestFitness.Name = "bestFitness";
            this.bestFitness.Size = new System.Drawing.Size(25, 29);
            this.bestFitness.TabIndex = 42;
            this.bestFitness.Text = "0";
            this.bestFitness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "WARTOŚĆ FUNKCJI CELU";
            // 
            // openFileEgzaminy
            // 
            this.openFileEgzaminy.FileName = "Exam";
            this.openFileEgzaminy.Filter = "(*.xml)|*.xml";
            this.openFileEgzaminy.Title = "Wczytaj listę egzaminów";
            // 
            // openFileEgzaminatorzy
            // 
            this.openFileEgzaminatorzy.FileName = "Examiner";
            this.openFileEgzaminatorzy.Filter = "(*.xml)|*.xml";
            this.openFileEgzaminatorzy.Title = "Wczytaj listę egzaminatorów";
            // 
            // Harmonogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 774);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Harmonogram";
            this.Text = "Harmonogram planowania egzaminów";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miOpenEgzaminy;
        private System.Windows.Forms.ToolStripMenuItem miOpenEgzaminatorzy;
        private System.Windows.Forms.ToolStripMenuItem egzaminyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazEgzaminyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egzaminatorzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazEgzaminatorowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGeneracji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerFor;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bestFitness;
        private System.Windows.Forms.OpenFileDialog openFileEgzaminy;
        private System.Windows.Forms.OpenFileDialog openFileEgzaminatorzy;
        private System.Windows.Forms.Label label1;
    }
}

