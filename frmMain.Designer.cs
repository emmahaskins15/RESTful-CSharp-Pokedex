namespace Pokedex
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spriteBoxMain = new System.Windows.Forms.PictureBox();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnCaught = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.caughtCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblType2);
            this.groupBox1.Controls.Add(this.lblType1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.spriteBoxMain);
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 9;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(45, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 20);
            this.lblNumber.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "No.";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(258, 107);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(0, 20);
            this.lblType2.TabIndex = 4;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(258, 42);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(0, 20);
            this.lblType1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height:";
            // 
            // spriteBoxMain
            // 
            this.spriteBoxMain.Location = new System.Drawing.Point(10, 65);
            this.spriteBoxMain.Name = "spriteBoxMain";
            this.spriteBoxMain.Size = new System.Drawing.Size(201, 175);
            this.spriteBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spriteBoxMain.TabIndex = 0;
            this.spriteBoxMain.TabStop = false;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(387, 44);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(90, 34);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnCaught
            // 
            this.btnCaught.Location = new System.Drawing.Point(387, 135);
            this.btnCaught.Name = "btnCaught";
            this.btnCaught.Size = new System.Drawing.Size(90, 60);
            this.btnCaught.TabIndex = 2;
            this.btnCaught.Text = "Caught Pokemon";
            this.btnCaught.UseVisualStyleBackColor = true;
            this.btnCaught.Click += new System.EventHandler(this.btnCaught_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrement.Location = new System.Drawing.Point(493, 59);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(39, 39);
            this.btnIncrement.TabIndex = 4;
            this.btnIncrement.Text = "⬆";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.Location = new System.Drawing.Point(493, 104);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(39, 39);
            this.btnDecrement.TabIndex = 5;
            this.btnDecrement.Text = "⬇";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // caughtCheckbox
            // 
            this.caughtCheckbox.AutoSize = true;
            this.caughtCheckbox.Location = new System.Drawing.Point(388, 274);
            this.caughtCheckbox.Name = "caughtCheckbox";
            this.caughtCheckbox.Size = new System.Drawing.Size(89, 24);
            this.caughtCheckbox.TabIndex = 6;
            this.caughtCheckbox.Text = "Caught?";
            this.caughtCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.caughtCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Weight:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 328);
            this.Controls.Add(this.caughtCheckbox);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnCaught);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spriteBoxMain;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnCaught;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.CheckBox caughtCheckbox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label2;
    }
}

