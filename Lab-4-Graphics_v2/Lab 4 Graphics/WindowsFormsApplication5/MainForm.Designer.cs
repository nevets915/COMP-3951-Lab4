namespace WindowsFormsApplication5
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeRectangleButton_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Elipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.customCanvas1 = new WindowsFormsApplication5.CustomCanvas();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.drawToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 36);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Clicked);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.shapeToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.BrushChangeButton_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShapeRectangleButton_Click,
            this.Elipse});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // ShapeRectangleButton_Click
            // 
            this.ShapeRectangleButton_Click.Name = "ShapeRectangleButton_Click";
            this.ShapeRectangleButton_Click.Size = new System.Drawing.Size(219, 38);
            this.ShapeRectangleButton_Click.Text = "Rectangle";
            this.ShapeRectangleButton_Click.Click += new System.EventHandler(this.BrushChangeButton_Click);
            // 
            // Elipse
            // 
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(219, 38);
            this.Elipse.Text = "Ellipse";
            this.Elipse.Click += new System.EventHandler(this.BrushChangeButton_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.brushToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.penColorToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 38);
            this.toolStripMenuItem2.Text = "Pen";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.BlackColorButton_Clicked);
            // 
            // penColorToolStripMenuItem
            // 
            this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
            this.penColorToolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.penColorToolStripMenuItem.Text = "Pen color";
            this.penColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorButton_Clicked);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1192, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 32);
            this.StatusLabel.Text = "Line";
            // 
            // customCanvas1
            // 
            this.customCanvas1.Location = new System.Drawing.Point(0, 52);
            this.customCanvas1.Margin = new System.Windows.Forms.Padding(6);
            this.customCanvas1.Name = "customCanvas1";
            this.customCanvas1.Size = new System.Drawing.Size(1192, 642);
            this.customCanvas1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 725);
            this.Controls.Add(this.customCanvas1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Steven Ma, George Lee February 2, 2017";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShapeRectangleButton_Click;
        private System.Windows.Forms.ToolStripMenuItem Elipse;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private CustomCanvas customCanvas1;
    }
}

