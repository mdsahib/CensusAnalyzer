using System;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Analytics
{
    public partial class BarChart : Form
    {
        int value = 0;

        public BarChart()
        {
            InitializeComponent();
            PrintingSettings_Load();
            MessageBox.Show(chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable.ToString());
            MessageBox.Show(chart1.ChartAreas["Default"].CursorX.IsUserEnabled.ToString());
            MessageBox.Show(chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled.ToString());
            
            



            


        }

        private void UpdateChart()
        {
            if (radioButtonBar.Checked)
            {
                // Set chart type to Bar
                chart1.Series["Default"].ChartType = SeriesChartType.Bar;
                chart1.Titles[0].Text = "3D Bar Diagram";
                //chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
               // chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
            }
            else
            {
                // Set chart type to Column
                chart1.Series["Default"].ChartType = SeriesChartType.Column;
                chart1.Titles[0].Text = "3D Colulmn Diagram";
            }

            // Disable/enable X axis margin
            chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

            // Disable/enable right angle axis
            chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = RightAngleAxis.Checked;

            // Disable/enable clustered series
            chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkClustered.Checked;

        
        }

        

        private void Inclination_ValueChanged(object sender, EventArgs e)
        {
            if (Inclination.Value > 90)
                Inclination.Value = -90;
            if (Inclination.Value < -90)
                Inclination.Value = 90;

            chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int)Inclination.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBoxRotate.Checked)
            {

               
                if (value > 90)
                    value = -90;
                if (value < -90)
                    value = 0;
                value++;

                chart1.ChartAreas["Default"].Area3DStyle.Rotation = value;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void checkClustered_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void RightAngleAxis_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        /// <summary>
        /// Start of Saving code
        /// </summary>

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

        /// <summary>
        /// Endd of Saving chsrt code
        /// </summary>
        /// 

        /// <summary>
        /// Start of printing panel code
        /// </summary>

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

        private void chart1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable.ToString());
            MessageBox.Show(chart1.ChartAreas["Default"].CursorX.IsUserEnabled.ToString());
            MessageBox.Show(chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled.ToString());

        }

        private void buttonResetZoom_Click(object sender, EventArgs e)
        {
            
                // Rese X axis zooming
                chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            
                // Rese Y axis zooming
                chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);
            
        }

        private void checkBoxZoomUI_CheckedChanged(object sender, EventArgs e)
        {


            // Reset to default
            chart1.ChartAreas[0].CursorX.IsUserEnabled = false;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = false;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = false;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = false;

            // Enable range selection and zooming UI
            if(checkBoxZoomUI.Checked)
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                chart1.ChartAreas[0].CursorX.IsUserEnabled = checkBoxZoomUI.Checked;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = checkBoxZoomUI.Checked;


                chart1.ChartAreas[0].CursorY.IsUserEnabled = checkBoxZoomUI.Checked;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = checkBoxZoomUI.Checked;
            }
            else chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        /// <summary>
        /// End of printing panel code
        /// </summary>


        /*  private void DataTable1_CheckedChanged_1(object sender, System.EventArgs e)
          {
              if (TableHelper == null)
              {
                  TableHelper = new ChartDataTableHelper();
                  TableHelper.Initialize(chart1);//, ShowTotals.Checked);
                  TableHelper.TableColor = Color.FromName(this.TableColor.SelectedText);
                  TableHelper.BorderColor = Color.FromName(this.BorderColor.SelectedText);
              }

              if (DataTable1.Checked)
                  TableHelper.AddDataTable("Default");
              else
                  TableHelper.RemoveDataTable("Default");

          }


          private void RemoveDataTable(string ChartAreaName)
          {
              TableHelper.RemoveDataTable(ChartAreaName);
          }
        
          */


        /// <summary>
        /// End of show datatable code
        /// </summary>





       
        


    }
}
