using LAB02.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class HomePage : Form
    {
        public int clicked_index;
        public MusicInfo musicInfo;
        public string previous = "null";
        public string next = "main";
        public HomePage()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;

            main.PanelClickedvn += main_listvn_clicked;
            main.PanelClickednn += main_listnn_clicked;
            enCategory.SongClicked += EnCategory_SongClicked;
            vnCategory.SongClicked += VNCategory_SongClicked;
            main.SongClicked += MainCategory_SongClicked;
        }

        private void Main_PanelClickednn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nhacVN_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "vnCategory";
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }

        private void nhacVNic_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "vnCategory";
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }

        private void nhacNN_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "enCategory";
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }

        private void nhacNNic_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "enCategory";
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "main";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
            this.musicInfo.Visible = false;
        }

        private void homeicon_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "main";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
            this.musicInfo.Visible = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "main";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
            this.musicInfo.Visible = false;
        }

        private void main_listvn_clicked(object sender, EventArgs e)
        {
            previous = "main";
            next = "vnCategory";
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }

        private void main_listnn_clicked(object sender, EventArgs e)
        {
            previous = "main";
            next = "enCategory";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = true;
            this.main.Visible = false;
            this.musicInfo.Visible = false;
        }
        private void EnCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            musicInfo = new MusicInfo(this.clicked_index);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);   
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";
        }

        private void VNCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            musicInfo = new MusicInfo(this.clicked_index);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";
        }
        private void MainCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            musicInfo = new MusicInfo(this.clicked_index);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Controls[previous].Visible = true;
            this.Controls[next].Visible = false;
            string temp = next;
            next = previous;
            previous = temp;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Controls[previous].Visible = false;
            this.Controls[next].Visible = true;
            string temp = next;
            next = previous;
            previous = temp;
        }
    }
}
