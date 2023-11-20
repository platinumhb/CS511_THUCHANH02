using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class VNCategory : UserControl
    {
        public event Action<int> SongClicked;
        public int clicked_index;

        public event Action<bool, int> LoveChanged;
        public int love_index;
        public bool love_check;
        public VNCategory()
        {
            int n = 16;
            InitializeComponent();
            for (int i = 1; i <= n; i++)
            {
                SongDemo song = new SongDemo(i);
                song.SongClicked += song_clicked;
                song.LoveChanged += love_changed;
                // Thêm Label vào FlowLayoutPanel
                this.Category.Controls.Add(song);
            }
        }

        private void Catogery_Load(object sender, EventArgs e)
        {
        
        }
        private void song_clicked(int index)
        {
            this.clicked_index = index;
            this.SongClicked?.Invoke(clicked_index);
        }
        private void love_changed(bool love_check, int index)
        {
            this.love_index = index;
            this.love_check = love_check;
            this.LoveChanged?.Invoke(love_check, love_index);
        }

    }
}
