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
        public VNCategory()
        {
            int n = 16;
            InitializeComponent();
            for (int i = 1; i <= n; i++)
            {
                SongDemo song = new SongDemo(i);

                // Thêm Label vào FlowLayoutPanel
                this.Category.Controls.Add(song);
            }
        }

        private void Catogery_Load(object sender, EventArgs e)
        {
        
        }
    }
}
