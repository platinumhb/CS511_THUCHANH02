using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class ENCategory : UserControl
    {
        public event Action<int> SongClicked;
        public int clicked_index;
        //public int temp;
        public ENCategory()
        {
            int n = 30;
            InitializeComponent();
            for (int i = 17; i <= n; i++)
            {
                SongDemo song = new SongDemo(i);
                song.Name = i.ToString();

                song.SongClicked += song_clicked;
                // Thêm Label vào FlowLayoutPanel
                this.Category.Controls.Add(song);
            }      
        }

        private void ENCategory_Load(object sender, EventArgs e)
        {

        }
        private void song_clicked(int index)
        {
            this.clicked_index = index;
            this.SongClicked?.Invoke(clicked_index);
        }


    }
}
