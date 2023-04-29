namespace Pokedex
{
    partial class frmStats
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
            this.webBrowserStats = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserStats
            // 
            this.webBrowserStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserStats.Location = new System.Drawing.Point(0, 0);
            this.webBrowserStats.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserStats.Name = "webBrowserStats";
            this.webBrowserStats.Size = new System.Drawing.Size(505, 382);
            this.webBrowserStats.TabIndex = 0;
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.webBrowserStats);
            this.Name = "frmStats";
            this.Text = "Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserStats;
    }
}