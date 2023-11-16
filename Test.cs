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
    public partial class Test : Form
    {
        public int clicked_index;
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            SongDemo song = new SongDemo(5);
            this.Controls.Add(song);
            enCategory.SongClicked += EnCategory_SongClicked;
        }
        private void EnCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            MusicInfo musicInfo = new MusicInfo(this.clicked_index);

            musicInfo.Location = new Point(0, 0);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();
        }
    }
}
