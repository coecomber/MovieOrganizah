namespace MovieOrganizer_2Leggo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorkeurenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veranderProfielfotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiesMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veranderPanelKleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 569);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.voorkeurenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(865, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 541);
            this.panel1.TabIndex = 2;
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiesMapToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // voorkeurenToolStripMenuItem
            // 
            this.voorkeurenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem});
            this.voorkeurenToolStripMenuItem.Name = "voorkeurenToolStripMenuItem";
            this.voorkeurenToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.voorkeurenToolStripMenuItem.Text = "Voorkeuren";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veranderProfielfotoToolStripMenuItem,
            this.veranderPanelKleurToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // veranderProfielfotoToolStripMenuItem
            // 
            this.veranderProfielfotoToolStripMenuItem.Name = "veranderProfielfotoToolStripMenuItem";
            this.veranderProfielfotoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.veranderProfielfotoToolStripMenuItem.Text = "Verander Profielfoto";
            this.veranderProfielfotoToolStripMenuItem.Click += new System.EventHandler(this.veranderProfielfotoToolStripMenuItem_Click);
            // 
            // kiesMapToolStripMenuItem
            // 
            this.kiesMapToolStripMenuItem.Name = "kiesMapToolStripMenuItem";
            this.kiesMapToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kiesMapToolStripMenuItem.Text = "Kies map";
            this.kiesMapToolStripMenuItem.Click += new System.EventHandler(this.kiesMapToolStripMenuItem_Click);
            // 
            // veranderPanelKleurToolStripMenuItem
            // 
            this.veranderPanelKleurToolStripMenuItem.Name = "veranderPanelKleurToolStripMenuItem";
            this.veranderPanelKleurToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.veranderPanelKleurToolStripMenuItem.Text = "Verander PanelKleur";
            this.veranderPanelKleurToolStripMenuItem.Click += new System.EventHandler(this.veranderPanelKleurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 569);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MovieOrganizerPoging2Leggo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voorkeurenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veranderProfielfotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiesMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veranderPanelKleurToolStripMenuItem;
    }
}

