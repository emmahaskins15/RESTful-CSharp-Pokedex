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
            this.statsWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.statsWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // statsWebView
            // 
            this.statsWebView.AllowExternalDrop = true;
            this.statsWebView.CreationProperties = null;
            this.statsWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.statsWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsWebView.Location = new System.Drawing.Point(0, 0);
            this.statsWebView.Name = "statsWebView";
            this.statsWebView.Size = new System.Drawing.Size(624, 928);
            this.statsWebView.TabIndex = 1;
            this.statsWebView.ZoomFactor = 1D;
            this.statsWebView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.statsWebView_CoreWebView2InitializationCompleted);
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 928);
            this.Controls.Add(this.statsWebView);
            this.Name = "frmStats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statsWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 statsWebView;
    }
}