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
    public partial class Favorite : UserControl
    {
        public event Action<int> SongClicked;
        public int clicked_index;
        public string favorite_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Favorite.txt";
        public string[] lines;
        public Favorite()
        {
            InitializeComponent();
            lines = File.ReadAllLines(this.favorite_path);

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
