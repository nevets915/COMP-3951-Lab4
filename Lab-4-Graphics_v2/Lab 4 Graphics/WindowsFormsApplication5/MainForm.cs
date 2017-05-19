using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// Purpose: Constructor for the MainForm Object.  It contains the menu items(toolbar), the 
    /// CustomerCanvas object, the pen statusbar etc.  
    /// Input: N/A
    /// Output: Displays the MainForm as a container of the form components to user.
    /// Author: George Lee and Steven Ma
    /// Date: 02-04-2017
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Variable for referencing the ColorDialogue object for changing the pen color to the color
        /// selected by the user.
        /// </summary>
        private ColorDialog colordialogue;
        /// <summary>
        /// Purpose: Constructor for the MainForm Object.  It contains the menu items(toolbar), the 
        /// CustomerCanvas object, the pen statusbar etc.  
        /// Input: N/A
        /// Output: Displays the MainForm as a container of the form components to user.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            colordialogue = new ColorDialog();
            this.customCanvas1.SetStatusLabel(this.StatusLabel);
        }
        /// <summary>
        /// Metthod for changing the status label for the pen if the user changes the pen/shape type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrushChangeButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = ((ToolStripMenuItem)sender).Text;
        }
        /// <summary>
        /// Method for bringing up the colour dialoguebox to allow user to choose the pen color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColorButton_Clicked(object sender, EventArgs e)
        {
            if (colordialogue.ShowDialog() == DialogResult.OK)
            {
                customCanvas1.ChangePenColor(colordialogue.Color);
            }
        }
        /// <summary>
        /// Method for changing the color of the pen to black if button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackColorButton_Clicked(object sender, EventArgs e)
        {
            customCanvas1.ChangePenColor(Color.Black);
        }
        /// <summary>
        /// Method for exiting the program after the "Exit" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}