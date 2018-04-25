namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 2D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Список Элементов", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_djons_1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_form_redactor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_enter_in = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_djons_2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_djons_3 = new System.Windows.Forms.Button();
            this.button_djons_4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_djons_1
            // 
            this.button_djons_1.BackColor = System.Drawing.Color.Silver;
            this.button_djons_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_djons_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_djons_1.Enabled = false;
            this.button_djons_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_djons_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_djons_1.Location = new System.Drawing.Point(3, 25);
            this.button_djons_1.Name = "button_djons_1";
            this.button_djons_1.Size = new System.Drawing.Size(195, 35);
            this.button_djons_1.TabIndex = 6;
            this.button_djons_1.Text = "Обобщение Джонсона 1";
            this.toolTip1.SetToolTip(this.button_djons_1, "В обработку сначала запускают детали, требующие минимальное время обработки на пе" +
        "рвом станке в порядке возрастания этого времени.");
            this.button_djons_1.UseVisualStyleBackColor = false;
            this.button_djons_1.Click += new System.EventHandler(this.button_djons_1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.Maximum = 3D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart1.Location = new System.Drawing.Point(0, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Name = "Series1";
            dataPoint1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            dataPoint1.BorderWidth = 1;
            dataPoint1.Color = System.Drawing.Color.White;
            dataPoint1.LabelBorderWidth = 1;
            dataPoint1.MarkerBorderColor = System.Drawing.Color.Black;
            dataPoint1.MarkerBorderWidth = 1;
            dataPoint1.MarkerColor = System.Drawing.Color.Black;
            dataPoint1.MarkerSize = 5;
            dataPoint1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "LabelStyle=Top";
            series2.Enabled = false;
            series2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Name = "Series2";
            dataPoint3.AxisLabel = "";
            dataPoint3.CustomProperties = "LabelStyle=Top";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.Label = "A0";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1161, 538);
            this.chart1.TabIndex = 9;
            title1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Диаграма Ганта";
            this.chart1.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Суммарное время обработки (с простоем): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Время простоя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(300, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(115, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // button_form_redactor
            // 
            this.button_form_redactor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_form_redactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_form_redactor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_form_redactor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_form_redactor.Location = new System.Drawing.Point(6, 79);
            this.button_form_redactor.Name = "button_form_redactor";
            this.button_form_redactor.Size = new System.Drawing.Size(335, 50);
            this.button_form_redactor.TabIndex = 14;
            this.button_form_redactor.Text = "Открыть редактор исходных данных";
            this.button_form_redactor.UseVisualStyleBackColor = false;
            this.button_form_redactor.Click += new System.EventHandler(this.button_form_redactor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_form_redactor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(187, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Время работы алгоритма: ";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "Список Элементов";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(351, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(219, 104);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_enter_in);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(570, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 104);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // button_enter_in
            // 
            this.button_enter_in.BackColor = System.Drawing.Color.Silver;
            this.button_enter_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_enter_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_enter_in.Enabled = false;
            this.button_enter_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_enter_in.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter_in.Location = new System.Drawing.Point(3, 25);
            this.button_enter_in.Name = "button_enter_in";
            this.button_enter_in.Size = new System.Drawing.Size(181, 76);
            this.button_enter_in.TabIndex = 8;
            this.button_enter_in.Text = "Построить для начального порядка";
            this.button_enter_in.UseVisualStyleBackColor = false;
            this.button_enter_in.Click += new System.EventHandler(this.button_enter_in_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_djons_1);
            this.groupBox2.Controls.Add(this.button_djons_2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(757, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 104);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // button_djons_2
            // 
            this.button_djons_2.BackColor = System.Drawing.Color.Silver;
            this.button_djons_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_djons_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_djons_2.Enabled = false;
            this.button_djons_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_djons_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_djons_2.Location = new System.Drawing.Point(3, 66);
            this.button_djons_2.Name = "button_djons_2";
            this.button_djons_2.Size = new System.Drawing.Size(195, 35);
            this.button_djons_2.TabIndex = 15;
            this.button_djons_2.Text = "Обобщение Джонсона 2";
            this.toolTip2.SetToolTip(this.button_djons_2, "В обработку запускаются сначала детали, требующие максимальное время обработки на" +
        " последнем станке в порядке убывания этого времени.");
            this.button_djons_2.UseVisualStyleBackColor = false;
            this.button_djons_2.Click += new System.EventHandler(this.button_djons_2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_djons_3);
            this.groupBox3.Controls.Add(this.button_djons_4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(958, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 104);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // button_djons_3
            // 
            this.button_djons_3.BackColor = System.Drawing.Color.Silver;
            this.button_djons_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_djons_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_djons_3.Enabled = false;
            this.button_djons_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_djons_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_djons_3.Location = new System.Drawing.Point(3, 25);
            this.button_djons_3.Name = "button_djons_3";
            this.button_djons_3.Size = new System.Drawing.Size(194, 35);
            this.button_djons_3.TabIndex = 16;
            this.button_djons_3.Text = "Обобщение Джонсона 3";
            this.toolTip3.SetToolTip(this.button_djons_3, resources.GetString("button_djons_3.ToolTip"));
            this.button_djons_3.UseVisualStyleBackColor = false;
            this.button_djons_3.Click += new System.EventHandler(this.button_djons_3_Click);
            // 
            // button_djons_4
            // 
            this.button_djons_4.BackColor = System.Drawing.Color.Silver;
            this.button_djons_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_djons_4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_djons_4.Enabled = false;
            this.button_djons_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_djons_4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_djons_4.Location = new System.Drawing.Point(3, 66);
            this.button_djons_4.Name = "button_djons_4";
            this.button_djons_4.Size = new System.Drawing.Size(194, 35);
            this.button_djons_4.TabIndex = 17;
            this.button_djons_4.Text = "Обобщение Джонсона 4";
            this.toolTip4.SetToolTip(this.button_djons_4, "Обрабатываются вначале детали, у которых суммарное время обработки на всех станка" +
        "х максимальное в порядке убывания этого времени.");
            this.button_djons_4.UseVisualStyleBackColor = false;
            this.button_djons_4.Click += new System.EventHandler(this.button_djons_4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 671);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1177, 710);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обобщения Джонсона";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_djons_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_form_redactor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_djons_4;
        private System.Windows.Forms.Button button_djons_3;
        private System.Windows.Forms.Button button_djons_2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_enter_in;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

