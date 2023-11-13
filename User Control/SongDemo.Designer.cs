namespace LAB02.User_Control
{
    partial class SongDemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongDemo));
            this.SongImage = new System.Windows.Forms.PictureBox();
            this.SongName = new System.Windows.Forms.Label();
            this.Singer = new System.Windows.Forms.Label();
            this.NotLovePB = new System.Windows.Forms.PictureBox();
            this.LovePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SongImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotLovePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LovePB)).BeginInit();
            this.SuspendLayout();
            // 
            // SongImage
            // 
            this.SongImage.Image = ((System.Drawing.Image)(resources.GetObject("SongImage.Image")));
            this.SongImage.Location = new System.Drawing.Point(10, 10);
            this.SongImage.Name = "SongImage";
            this.SongImage.Size = new System.Drawing.Size(130, 130);
            this.SongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SongImage.TabIndex = 0;
            this.SongImage.TabStop = false;
            // 
            // SongName
            // 
            this.SongName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SongName.Location = new System.Drawing.Point(147, 61);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(250, 58);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Lời tạm biệt chưa nói";
            // 
            // Singer
            // 
            this.Singer.AutoSize = true;
            this.Singer.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Singer.Location = new System.Drawing.Point(147, 35);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(72, 22);
            this.Singer.TabIndex = 1;
            this.Singer.Text = "GDucky";
            // 
            // NotLovePB
            // 
            this.NotLovePB.Image = ((System.Drawing.Image)(resources.GetObject("NotLovePB.Image")));
            this.NotLovePB.Location = new System.Drawing.Point(360, 0);
            this.NotLovePB.Name = "NotLovePB";
            this.NotLovePB.Size = new System.Drawing.Size(40, 40);
            this.NotLovePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotLovePB.TabIndex = 2;
            this.NotLovePB.TabStop = false;
            this.NotLovePB.Click += new System.EventHandler(this.NotLovePB_Click);
            // 
            // LovePB
            // 
            this.LovePB.Image = ((System.Drawing.Image)(resources.GetObject("LovePB.Image")));
            this.LovePB.Location = new System.Drawing.Point(360, 0);
            this.LovePB.Name = "LovePB";
            this.LovePB.Size = new System.Drawing.Size(40, 40);
            this.LovePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LovePB.TabIndex = 2;
            this.LovePB.TabStop = false;
            this.LovePB.Visible = false;
            this.LovePB.Click += new System.EventHandler(this.LovePB_Click);
            // 
            // SongDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LovePB);
            this.Controls.Add(this.NotLovePB);
            this.Controls.Add(this.Singer);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.SongImage);
            this.Name = "SongDemo";
            this.Size = new System.Drawing.Size(400, 148);
            this.Load += new System.EventHandler(this.SongDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotLovePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LovePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SongImage;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label Singer;
        private System.Windows.Forms.PictureBox NotLovePB;
        private System.Windows.Forms.PictureBox LovePB;
    }
}
