namespace Pokedex
{
    partial class frmCaught
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Bulbasaur", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaught));
            this.lstCaughtPokemon = new System.Windows.Forms.ListView();
            this.imageListSprites = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstCaughtPokemon
            // 
            this.lstCaughtPokemon.HideSelection = false;
            this.lstCaughtPokemon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstCaughtPokemon.LargeImageList = this.imageListSprites;
            this.lstCaughtPokemon.Location = new System.Drawing.Point(12, 12);
            this.lstCaughtPokemon.Name = "lstCaughtPokemon";
            this.lstCaughtPokemon.Size = new System.Drawing.Size(206, 245);
            this.lstCaughtPokemon.SmallImageList = this.imageListSprites;
            this.lstCaughtPokemon.TabIndex = 0;
            this.lstCaughtPokemon.UseCompatibleStateImageBehavior = false;
            this.lstCaughtPokemon.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageListSprites
            // 
            this.imageListSprites.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSprites.ImageStream")));
            this.imageListSprites.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSprites.Images.SetKeyName(0, "1.gif");
            // 
            // frmCaught
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 269);
            this.Controls.Add(this.lstCaughtPokemon);
            this.Name = "frmCaught";
            this.Text = "Caught Pokemon";
            this.Load += new System.EventHandler(this.frmCaught_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCaughtPokemon;
        private System.Windows.Forms.ImageList imageListSprites;
    }
}