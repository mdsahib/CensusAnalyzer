namespace Analytics
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEnable3D = new System.Windows.Forms.CheckBox();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.ShowLegend = new System.Windows.Forms.CheckBox();
            this.comboBoxDrwaingStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxExploded = new System.Windows.Forms.ComboBox();
            this.comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMargin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxOrientation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.CursorX.IsUserEnabled = true;
            chartArea6.CursorX.IsUserSelectionEnabled = true;
            chartArea6.CursorY.IsUserEnabled = true;
            chartArea6.CursorY.IsUserSelectionEnabled = true;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(0, 2);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(356, 331);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title6.BackColor = System.Drawing.Color.White;
            title6.BackImageTransparentColor = System.Drawing.Color.White;
            title6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            title6.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.ForeColor = System.Drawing.Color.Maroon;
            title6.Name = "Title1";
            title6.Text = "PIE CHART";
            this.chart1.Titles.Add(title6);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Label style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exploded Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rotate Chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Show Legend";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "3D View";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Drawing Style";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.checkBoxEnable3D);
            this.panel1.Controls.Add(this.checkBoxRotate);
            this.panel1.Controls.Add(this.ShowLegend);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxDrwaingStyle);
            this.panel1.Controls.Add(this.comboBoxExploded);
            this.panel1.Controls.Add(this.comboBoxLabelStyle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(352, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 340);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxEnable3D
            // 
            this.checkBoxEnable3D.AutoSize = true;
            this.checkBoxEnable3D.Location = new System.Drawing.Point(138, 191);
            this.checkBoxEnable3D.Name = "checkBoxEnable3D";
            this.checkBoxEnable3D.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnable3D.TabIndex = 11;
            this.checkBoxEnable3D.UseVisualStyleBackColor = true;
            this.checkBoxEnable3D.CheckedChanged += new System.EventHandler(this.checkBoxEbable3D_CheckedChanged);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(138, 159);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRotate.TabIndex = 10;
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.checkBoxRotate_CheckedChanged);
            // 
            // ShowLegend
            // 
            this.ShowLegend.AutoSize = true;
            this.ShowLegend.Checked = true;
            this.ShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLegend.Location = new System.Drawing.Point(138, 121);
            this.ShowLegend.Name = "ShowLegend";
            this.ShowLegend.Size = new System.Drawing.Size(15, 14);
            this.ShowLegend.TabIndex = 9;
            this.ShowLegend.UseVisualStyleBackColor = true;
            this.ShowLegend.CheckedChanged += new System.EventHandler(this.ShowLegend_CheckedChanged);
            // 
            // comboBoxDrwaingStyle
            // 
            this.comboBoxDrwaingStyle.FormattingEnabled = true;
            this.comboBoxDrwaingStyle.Items.AddRange(new object[] {
            "Default",
            "SoftEdge",
            "ConCave"});
            this.comboBoxDrwaingStyle.Location = new System.Drawing.Point(138, 229);
            this.comboBoxDrwaingStyle.Name = "comboBoxDrwaingStyle";
            this.comboBoxDrwaingStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrwaingStyle.TabIndex = 9;
            this.comboBoxDrwaingStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrwaingStyle_SelectedIndexChanged);
            // 
            // comboBoxExploded
            // 
            this.comboBoxExploded.FormattingEnabled = true;
            this.comboBoxExploded.Location = new System.Drawing.Point(133, 70);
            this.comboBoxExploded.Name = "comboBoxExploded";
            this.comboBoxExploded.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExploded.TabIndex = 8;
            // 
            // comboBoxLabelStyle
            // 
            this.comboBoxLabelStyle.FormattingEnabled = true;
            this.comboBoxLabelStyle.Items.AddRange(new object[] {
            "Inside",
            "Outside",
            "Disabled"});
            this.comboBoxLabelStyle.Location = new System.Drawing.Point(133, 18);
            this.comboBoxLabelStyle.Name = "comboBoxLabelStyle";
            this.comboBoxLabelStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLabelStyle.TabIndex = 7;
            this.comboBoxLabelStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelStyle_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 181);
            this.panel2.TabIndex = 8;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(138, 303);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.Text = "Copy Chart";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 303);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save Chart";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonPrint);
            this.panel3.Controls.Add(this.comboBoxResolution);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.comboBoxMargin);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.comboBoxOrientation);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.buttonPreview);
            this.panel3.Location = new System.Drawing.Point(0, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 181);
            this.panel3.TabIndex = 13;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrint.Location = new System.Drawing.Point(215, 128);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(120, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxResolution.Location = new System.Drawing.Point(168, 72);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(120, 21);
            this.comboBoxResolution.TabIndex = 5;
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolution_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Resolution:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMargin
            // 
            this.comboBoxMargin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMargin.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2"});
            this.comboBoxMargin.Location = new System.Drawing.Point(168, 40);
            this.comboBoxMargin.Name = "comboBoxMargin";
            this.comboBoxMargin.Size = new System.Drawing.Size(120, 21);
            this.comboBoxMargin.TabIndex = 3;
            this.comboBoxMargin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMargin_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "All Side &Margin (inch):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Portrait",
            "Landscape"});
            this.comboBoxOrientation.Location = new System.Drawing.Point(168, 8);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(120, 21);
            this.comboBoxOrientation.TabIndex = 1;
            this.comboBoxOrientation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrientation_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Page &Orientation:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPreview.Location = new System.Drawing.Point(73, 128);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(120, 23);
            this.buttonPreview.TabIndex = 6;
            this.buttonPreview.Text = "Print Previe&w";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "PieChart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxDrwaingStyle;
        private System.Windows.Forms.ComboBox comboBoxExploded;
        private System.Windows.Forms.ComboBox comboBoxLabelStyle;
        private System.Windows.Forms.CheckBox checkBoxEnable3D;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.CheckBox ShowLegend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMargin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxOrientation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPreview;
      
       
        
}
}

