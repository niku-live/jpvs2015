namespace Vol2Ex4_ColoringEditor
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nudažytiRaudonaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudažytiMėlynaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pažymėtiViskąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(634, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nudažytiRaudonaiToolStripMenuItem,
            this.nudažytiMėlynaiToolStripMenuItem,
            this.pažymėtiViskąToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 104);
            // 
            // nudažytiRaudonaiToolStripMenuItem
            // 
            this.nudažytiRaudonaiToolStripMenuItem.Name = "nudažytiRaudonaiToolStripMenuItem";
            this.nudažytiRaudonaiToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.nudažytiRaudonaiToolStripMenuItem.Text = "Nudažyti raudonai";
            this.nudažytiRaudonaiToolStripMenuItem.Click += new System.EventHandler(this.colorRedToolStripMenuItem_Click);
            // 
            // nudažytiMėlynaiToolStripMenuItem
            // 
            this.nudažytiMėlynaiToolStripMenuItem.Name = "nudažytiMėlynaiToolStripMenuItem";
            this.nudažytiMėlynaiToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.nudažytiMėlynaiToolStripMenuItem.Text = "Nudažyti mėlynai";
            this.nudažytiMėlynaiToolStripMenuItem.Click += new System.EventHandler(this.colorBlueToolStripMenuItem_Click);
            // 
            // pažymėtiViskąToolStripMenuItem
            // 
            this.pažymėtiViskąToolStripMenuItem.Name = "pažymėtiViskąToolStripMenuItem";
            this.pažymėtiViskąToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.pažymėtiViskąToolStripMenuItem.Text = "Pažymėti viską";
            this.pažymėtiViskąToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Coloring Editor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nudažytiRaudonaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nudažytiMėlynaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pažymėtiViskąToolStripMenuItem;
    }
}

