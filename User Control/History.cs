using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB02.User_Control
{
    public partial class History : UserControl
    {
        public event Action<int> SongClicked;
        //public BindingList<int> list = new BindingList<int>();
        public int clicked_index;

        public string history_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/History.txt";
        public string[] lines;
        public History()
        {
            InitializeComponent();
            lines = File.ReadAllLines(this.history_path);

            if (lines.Length > 0)
            {
                // Xử lý từng dòng
                foreach (string line in lines)
                {
                    int.TryParse(line, out int Index);

                    SongDemo song = new SongDemo(Index);
                    song.SongClicked += song_clicked;
                    this.Category.Controls.Add(song);
                }
            }
        }
        private void song_clicked(int index)
        {
            this.clicked_index = index;
            this.SongClicked?.Invoke(clicked_index);
        }


    }
}
