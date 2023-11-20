namespace LAB02.User_Control
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.Category = new System.Windows.Forms.FlowLayoutPanel();
            this.Discription = new System.Windows.Forms.Panel();
            this.ListName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Discription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.AutoScroll = true;
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.Category.ForeColor = System.Drawing.Color.Transparent;
            this.Category.Location = new System.Drawing.Point(0, 200);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(1252, 500);
            this.Category.TabIndex = 5;
            // 
            // Discription
            // 
            this.Discription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.Discription.Controls.Add(this.ListName);
            this.Discription.Controls.Add(this.label1);
            this.Discription.Controls.Add(this.pictureBox1);
            this.Discription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Discription.Location = new System.Drawing.Point(0, 0);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(1222, 200);
            this.Discription.TabIndex = 6;
            // 
            // ListName
            // 
            this.ListName.AutoSize = true;
            this.ListName.BackColor = System.Drawing.Color.Transparent;
            this.ListName.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListName.Location = new System.Drawing.Point(203, 79);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(171, 55);
            this.ListName.TabIndex = 2;
            this.ListName.Text = "History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHÁT CÔNG KHAI";
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
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Discription);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1222, 700);
            this.Discription.ResumeLayout(false);
            this.Discription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Discription;
        private System.Windows.Forms.Label ListName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.FlowLayoutPanel Category;
    }
}
