using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class Main : UserControl
    {
        public event Action<int> SongClicked;
        public int clicked_index;

        public event Action<bool, int> LoveChanged;
        public int love_index;
        public bool love_check;
        public Main()
        {
            int n = 30;
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
        public event EventHandler PanelClickedvn;
        public event EventHandler PanelClickednn;
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void listvn2_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void listvn1_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void listnn2_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void ListImage_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PanelClickedvn?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PanelClickednn?.Invoke(this, EventArgs.Empty);
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
