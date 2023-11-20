using System.ComponentModel;

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
            this.Next = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.playlistpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nhacNNic = new System.Windows.Forms.PictureBox();
            this.nhacNN = new System.Windows.Forms.Label();
            this.nhacVN = new System.Windows.Forms.Label();
            this.nhacVNic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loveic = new System.Windows.Forms.PictureBox();
            this.newplaylistic = new System.Windows.Forms.PictureBox();
            this.hisicon = new System.Windows.Forms.PictureBox();
            this.searchicon = new System.Windows.Forms.PictureBox();
            this.homeicon = new System.Windows.Forms.PictureBox();
            this.love = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.his = new System.Windows.Forms.Label();
            this.newpl = new System.Windows.Forms.Label();
            this.history_list = new LAB02.User_Control.History();
            this.favorite = new LAB02.User_Control.Favorite();
            this.searchBox = new LAB02.User_Control.SearchBox();
            this.main = new LAB02.User_Control.Main();
            this.vnCategory = new LAB02.User_Control.VNCategory();
            this.enCategory = new LAB02.User_Control.ENCategory();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacNNic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacVNic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loveic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newplaylistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).BeginInit();
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
            // Next
            // 
            resources.ApplyResources(this.Next, "Next");
            this.Next.Name = "Next";
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            resources.ApplyResources(this.Back, "Back");
            this.Back.Name = "Back";
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.playlistpanel);
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
            this.logo.Click += new System.EventHandler(this.home_Click);
            // 
            // playlistpanel
            // 
            this.playlistpanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.playlistpanel, "playlistpanel");
            this.playlistpanel.Name = "playlistpanel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.nhacNNic);
            this.panel2.Controls.Add(this.nhacNN);
            this.panel2.Controls.Add(this.nhacVN);
            this.panel2.Controls.Add(this.nhacVNic);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // nhacNNic
            // 
            resources.ApplyResources(this.nhacNNic, "nhacNNic");
            this.nhacNNic.Name = "nhacNNic";
            this.nhacNNic.TabStop = false;
            this.nhacNNic.Click += new System.EventHandler(this.nhacNN_Click);
            // 
            // nhacNN
            // 
            resources.ApplyResources(this.nhacNN, "nhacNN");
            this.nhacNN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhacNN.Name = "nhacNN";
            this.nhacNN.Click += new System.EventHandler(this.nhacNN_Click);
            // 
            // nhacVN
            // 
            resources.ApplyResources(this.nhacVN, "nhacVN");
            this.nhacVN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhacVN.Name = "nhacVN";
            this.nhacVN.Click += new System.EventHandler(this.nhacVN_Click);
            // 
            // nhacVNic
            // 
            resources.ApplyResources(this.nhacVNic, "nhacVNic");
            this.nhacVNic.Name = "nhacVNic";
            this.nhacVNic.TabStop = false;
            this.nhacVNic.Click += new System.EventHandler(this.nhacVN_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.loveic);
            this.panel3.Controls.Add(this.newplaylistic);
            this.panel3.Controls.Add(this.hisicon);
            this.panel3.Controls.Add(this.searchicon);
            this.panel3.Controls.Add(this.homeicon);
            this.panel3.Controls.Add(this.love);
            this.panel3.Controls.Add(this.home);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.newpl);
            this.panel3.Controls.Add(this.his);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // loveic
            // 
            resources.ApplyResources(this.loveic, "loveic");
            this.loveic.Name = "loveic";
            this.loveic.TabStop = false;
            this.loveic.Click += new System.EventHandler(this.loveic_Click);
            // 
            // newplaylistic
            // 
            resources.ApplyResources(this.newplaylistic, "newplaylistic");
            this.newplaylistic.Name = "newplaylistic";
            this.newplaylistic.TabStop = false;
            this.newplaylistic.Click += new System.EventHandler(this.newplaylist_Click);
            // 
            // hisicon
            // 
            resources.ApplyResources(this.hisicon, "hisicon");
            this.hisicon.Name = "hisicon";
            this.hisicon.TabStop = false;
            this.hisicon.Click += new System.EventHandler(this.hisicon_Click);
            // 
            // searchicon
            // 
            resources.ApplyResources(this.searchicon, "searchicon");
            this.searchicon.Name = "searchicon";
            this.searchicon.TabStop = false;
            this.searchicon.Click += new System.EventHandler(this.searchicon_Click);
            // 
            // homeicon
            // 
            resources.ApplyResources(this.homeicon, "homeicon");
            this.homeicon.Name = "homeicon";
            this.homeicon.TabStop = false;
            this.homeicon.Click += new System.EventHandler(this.home_Click);
            // 
            // love
            // 
            resources.ApplyResources(this.love, "love");
            this.love.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.love.Name = "love";
            this.love.Click += new System.EventHandler(this.love_Click);
            // 
            // home
            // 
            resources.ApplyResources(this.home, "home");
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Name = "home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Name = "search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // his
            // 
            resources.ApplyResources(this.his, "his");
            this.his.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.his.Name = "his";
            this.his.Click += new System.EventHandler(this.his_Click);
            // 
            // newpl
            // 
            resources.ApplyResources(this.newpl, "newpl");
            this.newpl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newpl.Name = "newpl";
            this.newpl.Click += new System.EventHandler(this.newplaylist_Click);
            // 
            // history_list
            // 
            resources.ApplyResources(this.history_list, "history_list");
            this.history_list.Name = "history_list";
            // 
            // favorite
            // 
            this.favorite.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.favorite, "favorite");
            this.favorite.Name = "favorite";
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.searchBox.Name = "searchBox";
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
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlBox = false;
            this.Controls.Add(this.history_list);
            this.Controls.Add(this.favorite);
            this.Controls.Add(this.searchBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacNNic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacVNic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loveic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newplaylistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.GroupBox title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.FlowLayoutPanel playlistpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox nhacNNic;
        private System.Windows.Forms.Label nhacNN;
        private System.Windows.Forms.Label nhacVN;
        private System.Windows.Forms.PictureBox nhacVNic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox loveic;
        private System.Windows.Forms.PictureBox newplaylistic;
        private System.Windows.Forms.PictureBox hisicon;
        private System.Windows.Forms.PictureBox searchicon;
        private System.Windows.Forms.PictureBox homeicon;
        private System.Windows.Forms.Label love;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label newplaylist;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label his;
        private User_Control.ENCategory enCategory;
        private User_Control.VNCategory vnCategory;
        private User_Control.Main main;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Back;
        private User_Control.SearchBox searchBox;
        //private User_Control.History historylist;
        private User_Control.Favorite favorite;
        private User_Control.History history_list;
        private System.Windows.Forms.Label newpl;
    }
}