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
            this.main.Visible = true;

            main.PanelClickedvn += main_listvn_clicked;
            main.PanelClickednn += main_listnn_clicked;
        }

        private void Main_PanelClickednn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nhacVN_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
        }

        private void nhacVNic_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
        }

        private void nhacNN_Click(object sender, EventArgs e)
        {
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
        }

        private void nhacNNic_Click(object sender, EventArgs e)
        {
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
        }

        private void homeicon_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
        }

        private void main_listvn_clicked(object sender, EventArgs e)
        {
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
        }

        private void main_listnn_clicked(object sender, EventArgs e)
        {
            this.vnCategory.Visible = false;
            this.enCategory.Visible = true;
            this.main.Visible = false;
        }
    }
}
