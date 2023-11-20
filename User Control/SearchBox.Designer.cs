namespace LAB02.User_Control
{
    partial class SearchBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.Category = new System.Windows.Forms.FlowLayoutPanel();
            this.nameBtt = new System.Windows.Forms.RadioButton();
            this.singerBtt = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.content);
            this.panel1.Controls.Add(this.search);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 50);
            this.panel1.TabIndex = 4;
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(3, 0);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(566, 50);
            this.content.TabIndex = 1;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            this.content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.content_KeyDown);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(573, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(48, 50);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 0;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.ForeColor = System.Drawing.Color.Transparent;
            this.Category.Location = new System.Drawing.Point(0, 61);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(987, 1550);
            this.Category.TabIndex = 6;
            // 
            // nameBtt
            // 
            this.nameBtt.AutoSize = true;
            this.nameBtt.BackColor = System.Drawing.Color.Transparent;
            this.nameBtt.Checked = true;
            this.nameBtt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBtt.Location = new System.Drawing.Point(641, 14);
            this.nameBtt.Name = "nameBtt";
            this.nameBtt.Size = new System.Drawing.Size(153, 23);
            this.nameBtt.TabIndex = 7;
            this.nameBtt.TabStop = true;
            this.nameBtt.Text = "Search by Name";
            this.nameBtt.UseVisualStyleBackColor = false;
            // 
            // singerBtt
            // 
            this.singerBtt.AutoSize = true;
            this.singerBtt.BackColor = System.Drawing.Color.Transparent;
            this.singerBtt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singerBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.singerBtt.Location = new System.Drawing.Point(802, 14);
            this.singerBtt.Name = "singerBtt";
            this.singerBtt.Size = new System.Drawing.Size(159, 23);
            this.singerBtt.TabIndex = 7;
            this.singerBtt.Text = "Search by Singer";
            this.singerBtt.UseVisualStyleBackColor = false;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.singerBtt);
            this.Controls.Add(this.nameBtt);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(1027, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.RadioButton nameBtt;
        private System.Windows.Forms.RadioButton singerBtt;
        public System.Windows.Forms.FlowLayoutPanel Category;
    }
}
