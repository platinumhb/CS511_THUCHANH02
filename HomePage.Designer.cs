namespace LAB02
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nhacVN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nhacNNic = new System.Windows.Forms.PictureBox();
            this.nhacNN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhacVNic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.libraryicon = new System.Windows.Forms.PictureBox();
            this.searchicon = new System.Windows.Forms.PictureBox();
            this.homeicon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.library = new System.Windows.Forms.Label();
            this.main = new LAB02.User_Control.Main();
            this.vnCategory = new LAB02.User_Control.VNCategory();
            this.enCategory = new LAB02.User_Control.ENCategory();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacNNic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacVNic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.title.Controls.Add(this.Next);
            this.title.Controls.Add(this.Back);
            this.title.Controls.Add(this.CloseButton);
            this.title.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.nhacVN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // nhacVN
            // 
            resources.ApplyResources(this.nhacVN, "nhacVN");
            this.nhacVN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhacVN.Name = "nhacVN";
            this.nhacVN.Click += new System.EventHandler(this.nhacVN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.nhacNNic);
            this.panel2.Controls.Add(this.nhacNN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nhacVNic);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // nhacNNic
            // 
            resources.ApplyResources(this.nhacNNic, "nhacNNic");
            this.nhacNNic.Name = "nhacNNic";
            this.nhacNNic.TabStop = false;
            this.nhacNNic.Click += new System.EventHandler(this.nhacNNic_Click);
            // 
            // nhacNN
            // 
            resources.ApplyResources(this.nhacNN, "nhacNN");
            this.nhacNN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhacNN.Name = "nhacNN";
            this.nhacNN.Click += new System.EventHandler(this.nhacNN_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // nhacVNic
            // 
            resources.ApplyResources(this.nhacVNic, "nhacVNic");
            this.nhacVNic.Name = "nhacVNic";
            this.nhacVNic.TabStop = false;
            this.nhacVNic.Click += new System.EventHandler(this.nhacVNic_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.libraryicon);
            this.panel3.Controls.Add(this.searchicon);
            this.panel3.Controls.Add(this.homeicon);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.home);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.library);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // libraryicon
            // 
            resources.ApplyResources(this.libraryicon, "libraryicon");
            this.libraryicon.Name = "libraryicon";
            this.libraryicon.TabStop = false;
            // 
            // searchicon
            // 
            resources.ApplyResources(this.searchicon, "searchicon");
            this.searchicon.Name = "searchicon";
            this.searchicon.TabStop = false;
            // 
            // homeicon
            // 
            resources.ApplyResources(this.homeicon, "homeicon");
            this.homeicon.Name = "homeicon";
            this.homeicon.TabStop = false;
            this.homeicon.Click += new System.EventHandler(this.homeicon_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // home
            // 
            resources.ApplyResources(this.home, "home");
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Name = "home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Name = "search";
            // 
            // library
            // 
            resources.ApplyResources(this.library, "library");
            this.library.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.library.Name = "library";
            // 
            // main
            // 
            resources.ApplyResources(this.main, "main");
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.main.Name = "main";
            // 
            // vnCategory
            // 
            this.vnCategory.BackColor = System.Drawing.Color.Transparent;
            this.vnCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.vnCategory, "vnCategory");
            this.vnCategory.Name = "vnCategory";
            // 
            // enCategory
            // 
            this.enCategory.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.enCategory, "enCategory");
            this.enCategory.Name = "enCategory";
            // 
            // Back
            // 
            resources.ApplyResources(this.Back, "Back");
            this.Back.Name = "Back";
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            resources.ApplyResources(this.Next, "Next");
            this.Next.Name = "Next";
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlBox = false;
            this.Controls.Add(this.title);
            this.Controls.Add(this.main);
            this.Controls.Add(this.vnCategory);
            this.Controls.Add(this.enCategory);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacNNic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacVNic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.GroupBox title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nhacVN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox nhacNNic;
        private System.Windows.Forms.Label nhacNN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nhacVNic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox libraryicon;
        private System.Windows.Forms.PictureBox searchicon;
        private System.Windows.Forms.PictureBox homeicon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label library;
        private User_Control.ENCategory enCategory;
        private User_Control.VNCategory vnCategory;
        private User_Control.Main main;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Back;
    }
}