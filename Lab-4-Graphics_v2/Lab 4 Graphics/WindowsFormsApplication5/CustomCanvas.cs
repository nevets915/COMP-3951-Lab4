using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// Purpose: Contstructor for the CustomCanvas.  The Canvas displays the drawn shapes
    /// to the user on the MainForm.  It sets the default pen to black and sets up a LinearGradientBrush
    /// object to display a gradient colored background. 
    /// Input: N/A
    /// Output: Displays drawn shapes to user.
    /// Author: George Lee and Steven Ma
    /// Date: 02-04-2017
    /// </summary>
    public partial class CustomCanvas : UserControl
    {
        /// <summary>
        /// Graphics variable used to reference and paint on the CustomerCanvas.
        /// </summary>
        private Graphics graphics;
        /// <summary>
        /// Point variables used to know where the user wishes to paint the shapes.
        /// </summary>
        private Point p1, p2;
        /// <summary>
        /// Boolean used to check if the first point has been given by the user.
        /// </summary>
        private bool p1_Assigned;
        /// <summary>
        /// Variable used to keep track of how many times the user has clicked on the Canvas.
        /// </summary>
        private int num_clicked;
        /// <summary>
        /// Variable used for referencing the pen object for the color to display on the Canvas.
        /// </summary>
        private Pen pen;
        /// <summary>
        /// Variable used to reference the LinearGradientBrush object for creating the gradient background
        /// color on the CustomCanvas.
        /// </summary>
        private LinearGradientBrush linearGradientBrush;
        /// <summary>
        /// Variable for referencing the StatusLabel that's passed through from MainForm.
        /// </summary>
        private ToolStripStatusLabel StatusLabel;
        /// <summary>
        /// Purpose: Contstructor for the CustomCanvas.  The Canvas displays the drawn shapes
        /// to the user on the MainForm.  It sets the default pen to black and sets up a LinearGradientBrush
        /// object to display a gradient colored background. 
        /// Input: N/A
        /// Output: Displays drawn shapes to user.
        /// </summary>
        public CustomCanvas()
        {
            InitializeComponent();
            p1_Assigned = false;
            pen = new Pen(Color.Black);
            linearGradientBrush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), 
                Color.AliceBlue, Color.Brown);
        }
        /// <summary>
        /// Method for setting the Custom Canvas to have a reference to the StatusLabel from MainForm.
        /// </summary>
        /// <param name="StatusLabel"></param>
        public void SetStatusLabel(ToolStripStatusLabel StatusLabel)
        {
            this.StatusLabel = StatusLabel;
        }
        /// <summary>
        /// Overriden Paint method for painting the line, rectangle or ellipse between two point objects,
        /// depending on what the user has set the pen to be.  This information is given by the StatusLabel
        /// from the MainForm.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(linearGradientBrush, 0, 0, this.Width, this.Height);
                if (StatusLabel != null && num_clicked % 2 == 0)
                {
                    graphics = e.Graphics;
                    if (StatusLabel.Text.Equals("Line"))
                    {
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (StatusLabel.Text.Equals("Rectangle"))
                    {
                        graphics.DrawRectangle(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), 
                            Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                    }
                    else if (StatusLabel.Text.Equals("Ellipse"))
                    {
                        graphics.DrawEllipse(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), 
                            Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }
        /// <summary>
        /// Method for changing the pen color to the color object choosen by the user.
        /// </summary>
        /// <param name="color"></param>
        public void ChangePenColor(Color color)
        {
            pen.Color = color;
        }
        /// <summary>
        /// Override method for clicking with the moues.  The method creates point objects for each 
        /// time the mouse is clicked on CustomCanvas. It validates whether two point objects have 
        /// been created before attempting to paint a new shape.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (!p1_Assigned)
            {
                p1 = new Point(e.X, e.Y);
                p1_Assigned = true;
            }
            else
            {
                p2 = new Point(e.X, e.Y);
                p1_Assigned = false;
            }
            num_clicked++;
            if (num_clicked % 2 == 0)
            {
                Invalidate();
            }
        }
    }
}