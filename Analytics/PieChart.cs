using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting.Utilities;





namespace Analytics
{
    

    public partial class PieChart : Form
    {
        private int angle = 0;
        
        

        public PieChart()
        {
            InitializeComponent();
            // Populate series data
            double[] yValues = { 65.62, 75.54, 60.45, 55.73, 70.42 };
            string[] xValues = { "France", "Canada", "UK", "USA", "Italy" };
            chart1.Series[0].Points.DataBindXY(xValues,yValues);
            //chart1.Titles[0].Text = " Pie Chart";
        }

        private void updateChart()
        {
            //Set labels style
            chart1.Series[0]["PieLabelStyle"] = comboBoxLabelStyle.Text;
            //set legends
            chart1.Legends[0].Enabled = ShowLegend.Checked;
            // Enable 3D
            chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxEnable3D.Checked;

            // Pie drawing style
            if (this.checkBoxEnable3D.Checked)
                this.comboBoxDrwaingStyle.Enabled = false;

            else
                this.comboBoxDrwaingStyle.Enabled = true;
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            comboBoxDrwaingStyle.SelectedIndex = 0;
            comboBoxLabelStyle.SelectedIndex = 0;

            PrintingSettings_Load();
            BasicZooming_Load();
            

        }


        private void comboBoxLabelStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart();
        }

        

        private void ShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            updateChart();
        }

        private void checkBoxEbable3D_CheckedChanged(object sender, EventArgs e)
        {
            updateChart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBoxRotate.Checked)
            {
                angle += 1;
                if (angle >= 360)
                {
                    angle = 0;
                }
                chart1.Series[0]["PieStartAngle"] = angle.ToString();
            }
        }

        private void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            //updateChart();
        }

        private void comboBoxDrwaingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0]["PieDrawingStyle"] = this.comboBoxDrwaingStyle.SelectedItem.ToString();
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
			saveFileDialog1.FilterIndex = 2 ;
			saveFileDialog1.RestoreDirectory = true ;
 
			// Set image file format
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{

				ChartImageFormat format = ChartImageFormat.Bmp;

				if( saveFileDialog1.FileName.EndsWith( "bmp" ) )
				{
					format = ChartImageFormat.Bmp;
				}
				else if( saveFileDialog1.FileName.EndsWith( "jpg" ) )
				{
					format = ChartImageFormat.Jpeg;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 3)
				{
					format = ChartImageFormat.EmfDual;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 4 )
				{
					format = ChartImageFormat.EmfPlus;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) )
				{
					format = ChartImageFormat.Emf;
				}
				else if( saveFileDialog1.FileName.EndsWith( "gif" ) )
				{
					format = ChartImageFormat.Gif;
				}
				else if( saveFileDialog1.FileName.EndsWith( "png" ) )
				{
					format = ChartImageFormat.Png;
				}
				else if( saveFileDialog1.FileName.EndsWith( "tif" ) )
				{
					format = ChartImageFormat.Tiff;
				}

				// Save image
				chart1.SaveImage( saveFileDialog1.FileName, format );
			
		}

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            
			// create a memory stream to save the chart image    
			System.IO.MemoryStream stream = new System.IO.MemoryStream();     

			// save the chart image to the stream    
			chart1.SaveImage(stream,System.Drawing.Imaging.ImageFormat.Bmp);     

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





        /// <summary>
        /// start of zooming panel code
        /// </summary>
        private void BasicZooming_Load()
        {
            

            // Enable range selection and zooming UI by default
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

           
            
        }

       

       

        

              
        /// <summary>
        /// End of zooming panel code
        /// </summary>
        /// 


        /// <summary>
        /// Start of pie selection code
        /// </summary>
        /// 
        

        /// <summary>
        /// Mouse Move Event
        /// </summary>
        private void chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Call Hit Test Method
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // Reset Data Point Attributes
            foreach (DataPoint point in chart1.Series[0].Points)
            {
                point.BackSecondaryColor = Color.Black;
                point.BackHatchStyle = ChartHatchStyle.None;
                point.BorderWidth = 1;
            }

            // If a Data Point or a Legend item is selected.
            if
            (result.ChartElementType == ChartElementType.DataPoint ||
                result.ChartElementType == ChartElementType.LegendItem)
            {
                // Set cursor type 
                this.Cursor = Cursors.Hand;

                // Find selected data point
                DataPoint point = chart1.Series[0].Points[result.PointIndex];

                // Set End Gradient Color to White
                point.BackSecondaryColor = Color.White;

                // Set selected hatch style
                point.BackHatchStyle = ChartHatchStyle.Percent25;

                // Increase border width
                point.BorderWidth = 2;
            }
            else
            {
                // Set default cursor
                this.Cursor = Cursors.Default;
            }

        }

        /// <summary>
        /// Mouse Down Event
        /// </summary>
        private void chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Call Hit Test Method
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // Exit event if no item was clicked on (PointResult will be negative one)
            if (result.PointIndex < 0)
                return;

            // Check if data point is already exploded.
            bool exploded = (chart1.Series[0].Points[result.PointIndex].CustomProperties == "Exploded=true") ? true : false;

            // Remove all exploded attributes
            foreach (DataPoint point in chart1.Series[0].Points)
            {
                point.CustomProperties = "";
            }

            // If data point is already exploded get out.
            if (exploded)
                return;

            // If data point is selected
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Set Attribute
                DataPoint point = chart1.Series[0].Points[result.PointIndex];
                point.CustomProperties = "Exploded = true";
            }

            // If legend item is selected
            if (result.ChartElementType == ChartElementType.LegendItem)
            {
                // Set Attribute
                DataPoint point = chart1.Series[0].Points[result.PointIndex];
                point.CustomProperties = "Exploded = true";
            }
        }

        private void comboBoxOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMargin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        

        


        /// <summary>
        /// End of pie selection code
        /// </summary>




        

        
    }//
}//
