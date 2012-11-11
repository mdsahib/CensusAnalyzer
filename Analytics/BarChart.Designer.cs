namespace Analytics
{
    partial class BarChart
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5.6999998092651367);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.2000000476837158);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6.5);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkClustered = new System.Windows.Forms.CheckBox();
            this.Inclination = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RightAngleAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this.radioButtonColumn = new System.Windows.Forms.RadioButton();
            this.radioButtonBar = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Rotation = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMargin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxOrientation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonResetZoom = new System.Windows.Forms.Button();
            this.checkBoxZoomUI = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inclination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotation)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.checkBoxRotate);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkClustered);
            this.panel1.Controls.Add(this.Inclination);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RightAngleAxis);
            this.panel1.Controls.Add(this.checkBoxShowMargin);
            this.panel1.Controls.Add(this.radioButtonColumn);
            this.panel1.Controls.Add(this.radioButtonBar);
            this.panel1.Location = new System.Drawing.Point(414, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 3;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(156, 250);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 14;
            this.buttonCopy.Text = "Copy Chart";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(171, 173);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRotate.TabIndex = 12;
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(30, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save Chart";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rotate Chart";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkClustered
            // 
            this.checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkClustered.Checked = true;
            this.checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkClustered.Location = new System.Drawing.Point(38, 137);
            this.checkClustered.Name = "checkClustered";
            this.checkClustered.Size = new System.Drawing.Size(144, 24);
            this.checkClustered.TabIndex = 4;
            this.checkClustered.Text = "&Clustered:";
            this.checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkClustered.CheckedChanged += new System.EventHandler(this.checkClustered_CheckedChanged);
            // 
            // Inclination
            // 
            this.Inclination.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Inclination.Location = new System.Drawing.Point(171, 200);
            this.Inclination.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Inclination.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Inclination.Name = "Inclination";
            this.Inclination.Size = new System.Drawing.Size(56, 20);
            this.Inclination.TabIndex = 6;
            this.Inclination.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Inclination.ValueChanged += new System.EventHandler(this.Inclination_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rotate &Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightAngleAxis
            // 
            this.RightAngleAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightAngleAxis.Location = new System.Drawing.Point(37, 106);
            this.RightAngleAxis.Name = "RightAngleAxis";
            this.RightAngleAxis.Size = new System.Drawing.Size(144, 24);
            this.RightAngleAxis.TabIndex = 3;
            this.RightAngleAxis.Text = "&Right Angle Axes:";
            this.RightAngleAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightAngleAxis.CheckedChanged += new System.EventHandler(this.RightAngleAxis_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this.checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.Checked = true;
            this.checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMargin.Location = new System.Drawing.Point(5, 72);
            this.checkBoxShowMargin.Name = "checkBoxShowMargin";
            this.checkBoxShowMargin.Size = new System.Drawing.Size(176, 24);
            this.checkBoxShowMargin.TabIndex = 2;
            this.checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this.checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            this.radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonColumn.Checked = true;
            this.radioButtonColumn.Location = new System.Drawing.Point(30, 42);
            this.radioButtonColumn.Name = "radioButtonColumn";
            this.radioButtonColumn.Size = new System.Drawing.Size(152, 24);
            this.radioButtonColumn.TabIndex = 1;
            this.radioButtonColumn.TabStop = true;
            this.radioButtonColumn.Text = "3D C&olumn Chart:";
            this.radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonBar
            // 
            this.radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonBar.Location = new System.Drawing.Point(45, 12);
            this.radioButtonBar.Name = "radioButtonBar";
            this.radioButtonBar.Size = new System.Drawing.Size(136, 24);
            this.radioButtonBar.TabIndex = 0;
            this.radioButtonBar.Text = "            3D Bar Chart:";
            this.radioButtonBar.CheckedChanged += new System.EventHandler(this.radioButtonBar_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 12;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 12;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Black;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 47);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(417, 288);
            this.chart1.TabIndex = 4;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Bar and Column charts.";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 90;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Rotation
            // 
            this.Rotation.Location = new System.Drawing.Point(0, 0);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(120, 20);
            this.Rotation.TabIndex = 0;
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
            this.panel3.Location = new System.Drawing.Point(-4, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 181);
            this.panel3.TabIndex = 16;
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
            // buttonResetZoom
            // 
            this.buttonResetZoom.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResetZoom.Location = new System.Drawing.Point(501, 415);
            this.buttonResetZoom.Name = "buttonResetZoom";
            this.buttonResetZoom.Size = new System.Drawing.Size(112, 23);
            this.buttonResetZoom.TabIndex = 9;
            this.buttonResetZoom.Text = "&Reset Zoom";
            this.buttonResetZoom.UseVisualStyleBackColor = false;
            this.buttonResetZoom.Click += new System.EventHandler(this.buttonResetZoom_Click);
            // 
            // checkBoxZoomUI
            // 
            this.checkBoxZoomUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxZoomUI.Location = new System.Drawing.Point(428, 374);
            this.checkBoxZoomUI.Name = "checkBoxZoomUI";
            this.checkBoxZoomUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxZoomUI.Size = new System.Drawing.Size(168, 16);
            this.checkBoxZoomUI.TabIndex = 17;
            this.checkBoxZoomUI.Text = "&Enable Zooming UI:";
            this.checkBoxZoomUI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxZoomUI.CheckedChanged += new System.EventHandler(this.checkBoxZoomUI_CheckedChanged);
            // 
            // BarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 483);
            this.Controls.Add(this.checkBoxZoomUI);
            this.Controls.Add(this.buttonResetZoom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "BarChart";
            this.Text = "BarChart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inclination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkClustered;
        private System.Windows.Forms.NumericUpDown Inclination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox RightAngleAxis;
        private System.Windows.Forms.CheckBox checkBoxShowMargin;
        private System.Windows.Forms.RadioButton radioButtonColumn;
        private System.Windows.Forms.RadioButton radioButtonBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Rotation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMargin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxOrientation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonResetZoom;
        private System.Windows.Forms.CheckBox checkBoxZoomUI;
    }
}