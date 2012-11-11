using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting.Utilities;


namespace Analytics
{
    public partial class FunnelChart : Form
    {
        public FunnelChart()
        {
            InitializeComponent();
            comboBoxLabelsStyle.SelectedIndex = 0;
            comboBox3DDrawingStyle.SelectedIndex = 0;
          
        }

        private void FunnelChart_Load(object sender, EventArgs e)
        {
            comboBoxLabelsStyle.SelectedIndex = 0;
            comboBox3DDrawingStyle.SelectedIndex = 0;
            numericUpDownGap.Value=3;
            chart1.Series["Default"]["FunnelMinPointHeight"] = numericUpDownMinHeight.Value.ToString();
            PrintingSettings_Load();

        }


        private void UpdateChartSettings()
        {
            // Bind chart data
            double[] yValues1 = new double[] { 216.1, 125.8, 2.6, 97.3, 45.7, 25.3 };
            double[] yValues2 = new double[] { 232.8, 195.4, 172.9, 100.3, 45.7, 25.3 };
            

            

            // Set funnel data point labels style
            chart1.Series["Default"]["FunnelLabelStyle"] = (string)comboBoxLabelsStyle.SelectedItem;

            // Set labels placement
            if (comboBoxLabelsStyle.SelectedIndex == 0 ||
                comboBoxLabelsStyle.SelectedIndex == 1)
            {
                chart1.Series["Default"]["FunnelOutsideLabelPlacement"] = (string)comboBoxLabelsPlacement.SelectedItem;
            }
            else
            {
                chart1.Series["Default"]["FunnelInsideLabelAlignment"] = (string)comboBoxLabelsPlacement.SelectedItem;
            }

            // Set gap between points
            chart1.Series["Default"]["FunnelPointGap"] = numericUpDownGap.Value.ToString();

            // Set minimum point height
            chart1.Series["Default"]["FunnelMinPointHeight"] = numericUpDownMinHeight.Value.ToString();

            // Set 3D mode
            chart1.ChartAreas["Default"].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

            // Set 3D angle
            chart1.Series["Default"]["Funnel3DRotationAngle"] = numericUpDownAngle.Value.ToString();

            // Set 3D drawing style
            chart1.Series["Default"]["Funnel3DDrawingStyle"] = (string)comboBox3DDrawingStyle.SelectedItem;

            // Disable/Enable controls
            numericUpDownAngle.Enabled = checkBoxShow3D.Checked;
            labelAngle.Enabled = checkBoxShow3D.Checked;
            comboBox3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
            label3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
            comboBoxLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;
            labelOutsideLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;

            chart1.Invalidate();
        }

        private void comboBoxLabelsStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLabelsPlacement.Items.Clear();
            if (comboBoxLabelsStyle.SelectedIndex == 0 ||
                comboBoxLabelsStyle.SelectedIndex == 1)
            {
                comboBoxLabelsPlacement.Items.Add("Right");
                comboBoxLabelsPlacement.Items.Add("Left");
            }
            else
            {
                comboBoxLabelsPlacement.Items.Add("Center");
                comboBoxLabelsPlacement.Items.Add("Top");
                comboBoxLabelsPlacement.Items.Add("Bottom");
            }
            comboBoxLabelsPlacement.SelectedIndex = 0;
            UpdateChartSettings();	
        }

        private void comboBoxLabelsPlacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();

        }

        private void numericUpDownGap_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownMinHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBox3DDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMargin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        

        

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // Create a new save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Sets the current file name filter string, which determines 
            // the choices that appear in the "Save as file type" or 
            // "Files of type" box in the dialog box.
            saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF-Plus (*.emf)|*.emf|EMF-Dual (*.emf)|*.emf|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            // Set image file format
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ChartImageFormat format = ChartImageFormat.Bmp;

                if (saveFileDialog1.FileName.EndsWith("bmp"))
                {
                    format = ChartImageFormat.Bmp;
                }
                else if (saveFileDialog1.FileName.EndsWith("jpg"))
                {
                    format = ChartImageFormat.Jpeg;
                }
                else if (saveFileDialog1.FileName.EndsWith("emf") && saveFileDialog1.FilterIndex == 3)
                {
                    format = ChartImageFormat.EmfDual;
                }
                else if (saveFileDialog1.FileName.EndsWith("emf") && saveFileDialog1.FilterIndex == 4)
                {
                    format = ChartImageFormat.EmfPlus;
                }
                else if (saveFileDialog1.FileName.EndsWith("emf"))
                {
                    format = ChartImageFormat.Emf;
                }
                else if (saveFileDialog1.FileName.EndsWith("gif"))
                {
                    format = ChartImageFormat.Gif;
                }
                else if (saveFileDialog1.FileName.EndsWith("png"))
                {
                    format = ChartImageFormat.Png;
                }
                else if (saveFileDialog1.FileName.EndsWith("tif"))
                {
                    format = ChartImageFormat.Tiff;
                }

                // Save image
                chart1.SaveImage(saveFileDialog1.FileName, format);

            }

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

            // create a memory stream to save the chart image    
            System.IO.MemoryStream stream = new System.IO.MemoryStream();

            // save the chart image to the stream    
            chart1.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp);

            // create a bitmap using the stream    
            Bitmap bmp = new Bitmap(stream);

            // save the bitmap to the clipboard    
            Clipboard.SetDataObject(bmp);

        }




        private void SetPrintingSettings()
        {
            // Set page orientation
            if (comboBoxOrientation.Text == "Landscape")
            {
                chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            }
            else
            {
                chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = false;
            }

            // Set page margins
            int margin = (int)(float.Parse(comboBoxMargin.Text) * 100f);
            chart1.Printing.PrintDocument.DefaultPageSettings.Margins =
                new System.Drawing.Printing.Margins(margin, margin, margin, margin);

            // Set printer resolution
            foreach (PrinterResolution pr in chart1.Printing.PrintDocument.PrinterSettings.PrinterResolutions)
            {
                if (pr.Kind.ToString() == comboBoxResolution.Text)
                {
                    chart1.Printing.PrintDocument.DefaultPageSettings.PrinterResolution = pr;
                }
            }
        }

        private void buttonPreview_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Set settings
                SetPrintingSettings();

                // Print preview chart
                chart1.Printing.PrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Set settings
                SetPrintingSettings();

                // Print chart
                chart1.Printing.Print(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PrintingSettings_Load()
        {
            comboBoxOrientation.SelectedIndex = 0;
            comboBoxMargin.SelectedIndex = 1;
            comboBoxResolution.SelectedIndex = 1;
        }

        /// <summary>
        /// End of printing panel code
        /// </summary>

    }
}
