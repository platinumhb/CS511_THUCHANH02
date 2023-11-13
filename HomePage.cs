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
        }

        private void nhacVN_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
        }

        private void nhacVNic_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
        }

        private void nhacNN_Click(object sender, EventArgs e)
        {
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
        }

        private void nhacNNic_Click(object sender, EventArgs e)
        {
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
        }
    }
}
