namespace LAB02.User_Control
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.Category = new System.Windows.Forms.FlowLayoutPanel();
            this.Discription = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.renamebtt = new System.Windows.Forms.PictureBox();
            this.namelb = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.Discription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renamebtt)).BeginInit();
            this.SuspendLayout();
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.AutoScroll = true;
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Category.ForeColor = System.Drawing.Color.Transparent;
            this.Category.Location = new System.Drawing.Point(0, 200);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(1249, 500);
            this.Category.TabIndex = 5;
            // 
            // Discription
            // 
            this.Discription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Discription.Controls.Add(this.nametb);
            this.Discription.Controls.Add(this.renamebtt);
            this.Discription.Controls.Add(this.namelb);
            this.Discription.Controls.Add(this.label1);
            this.Discription.Controls.Add(this.pictureBox1);
            this.Discription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Discription.Location = new System.Drawing.Point(0, 0);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(1222, 200);
            this.Discription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHÁT CÔNG NGƯỜI DÙNG TẠO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // renamebtt
            // 
            this.renamebtt.Image = ((System.Drawing.Image)(resources.GetObject("renamebtt.Image")));
            this.renamebtt.Location = new System.Drawing.Point(213, 140);
            this.renamebtt.Name = "renamebtt";
            this.renamebtt.Size = new System.Drawing.Size(20, 20);
            this.renamebtt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.renamebtt.TabIndex = 3;
            this.renamebtt.TabStop = false;
            this.renamebtt.Click += new System.EventHandler(this.renameBtt_Click);
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.BackColor = System.Drawing.Color.Transparent;
            this.namelb.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namelb.Location = new System.Drawing.Point(203, 79);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(269, 55);
            this.namelb.TabIndex = 2;
            this.namelb.Text = "NewPlayList";
            // 
            // nametb
            // 
            this.nametb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametb.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.ForeColor = System.Drawing.Color.White;
            this.nametb.Location = new System.Drawing.Point(213, 84);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(274, 50);
            this.nametb.TabIndex = 5;
            this.nametb.Text = "NewPlayList";
            this.nametb.Visible = false;
            this.nametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametb_KeyDown);
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Discription);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(1222, 700);
            this.Discription.ResumeLayout(false);
            this.Discription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renamebtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel Category;
        public System.Windows.Forms.Panel Discription;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox renamebtt;
        private System.Windows.Forms.TextBox nametb;
        public System.Windows.Forms.Label namelb;
    }
}
