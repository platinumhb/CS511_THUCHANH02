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
    public partial class ENCategory : UserControl
    {
        public ENCategory()
        {
            int n = 30;
            InitializeComponent();
            for (int i = 17; i <= n; i++)
            {
                SongDemo song = new SongDemo(i);

                // Thêm Label vào FlowLayoutPanel
                this.Category.Controls.Add(song);

            }
        }

        private void ENCategory_Load(object sender, EventArgs e)
        {

        }

        private void ENCategory_Load_1(object sender, EventArgs e)
        {

        }
    }
}
