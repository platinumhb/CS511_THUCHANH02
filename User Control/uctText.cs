using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02.User_Control
{
    public partial class uctText : UserControl
    {
        public uctText(string text)
        {
            InitializeComponent();
            comment.Multiline = true;
            this.comment.Text = text;
            int totallength = text.Length;
            int wordperline = 22;
            int x = (totallength / wordperline);
            this.comment.SelectionLength = 0;
            this.comment.SelectionStart = 0;
            
            if (x >= 2)
                comment.Height = (x) * 28;
            else comment.Height = 60;

            this.comment.SelectionLength = 0;
            this.comment.SelectionStart = 0;
            
        }

        private void uctText_Load(object sender, EventArgs e)
        {
            //comment.ScrollBars = ScrollBars.None;

            this.nostar1.Visible = true;
            this.nostar2.Visible = true;
            this.nostar3.Visible = true;
            this.nostar4.Visible = true;
            this.nostar5.Visible = true;
            this.star1.Visible = false;
            this.star2.Visible = false;
            this.star3.Visible = false;
            this.star4.Visible = false;
            this.star5.Visible = false;
        }

        public void Content(string text, Image image)
        {
            comment.Text = text;
            icon.BackgroundImage = image;
            icon.Image = image;
        }

        private void nostar1_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = false;
            this.nostar2.Visible = true;
            this.nostar3.Visible = true;
            this.nostar4.Visible = true;
            this.nostar5.Visible = true;
            this.star1.Visible = true;
            this.star2.Visible = false;
            this.star3.Visible = false;
            this.star4.Visible = false;
            this.star5.Visible = false;
        }

        private void nostar2_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = false;
            this.nostar2.Visible = false;
            this.nostar3.Visible = true;
            this.nostar4.Visible = true;
            this.nostar5.Visible = true;
            this.star1.Visible = true;
            this.star2.Visible = true;
            this.star3.Visible = false;
            this.star4.Visible = false;
            this.star5.Visible = false;
        }

        private void nostar3_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = false;
            this.nostar2.Visible = false;
            this.nostar3.Visible = false;
            this.nostar4.Visible = true;
            this.nostar5.Visible = true;
            this.star1.Visible = true;
            this.star2.Visible = true;
            this.star3.Visible = true;
            this.star4.Visible = false;
            this.star5.Visible = false;
        }

        private void nostar4_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = false;
            this.nostar2.Visible = false;
            this.nostar3.Visible = false;
            this.nostar4.Visible = false;
            this.nostar5.Visible = true;
            this.star1.Visible = true;
            this.star2.Visible = true;
            this.star3.Visible = true;
            this.star4.Visible = true;
            this.star5.Visible = false;
        }

        private void nostar5_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = false;
            this.nostar2.Visible = false;
            this.nostar3.Visible = false;
            this.nostar4.Visible = false;
            this.nostar5.Visible = false;
            this.star1.Visible = true;
            this.star2.Visible = true;
            this.star3.Visible = true;
            this.star4.Visible = true;
            this.star5.Visible = true;
        }

        private void star1_Click(object sender, EventArgs e)
        {
            if (star2.Visible == true)
            {
                this.nostar1.Visible = false;
                this.nostar2.Visible = true;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = true;
                this.star2.Visible = false;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
            else
            {
                this.nostar1.Visible = true;
                this.nostar2.Visible = true;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = false;
                this.star2.Visible = false;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            if (star3.Visible == true)
            {
                this.nostar1.Visible = false;
                this.nostar2.Visible = false;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = true;
                this.star2.Visible = true;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
            else
            {
                this.nostar1.Visible = true;
                this.nostar2.Visible = true;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = false;
                this.star2.Visible = false;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
              
        }

        private void star3_Click(object sender, EventArgs e)
        {
            if (star4.Visible == true)
            {
                this.nostar1.Visible = false;
                this.nostar2.Visible = false;
                this.nostar3.Visible = false;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = true;
                this.star2.Visible = true;
                this.star3.Visible = true;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
            else
            {
                this.nostar1.Visible = true;
                this.nostar2.Visible = true;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = false;
                this.star2.Visible = false;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            if (star5.Visible == true)
            {
                this.nostar1.Visible = false;
                this.nostar2.Visible = false;
                this.nostar3.Visible = false;
                this.nostar4.Visible = false;
                this.nostar5.Visible = true;
                this.star1.Visible = true;
                this.star2.Visible = true;
                this.star3.Visible = true;
                this.star4.Visible = true;
                this.star5.Visible = false;
            }
            else
            {
                this.nostar1.Visible = true;
                this.nostar2.Visible = true;
                this.nostar3.Visible = true;
                this.nostar4.Visible = true;
                this.nostar5.Visible = true;
                this.star1.Visible = false;
                this.star2.Visible = false;
                this.star3.Visible = false;
                this.star4.Visible = false;
                this.star5.Visible = false;
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            this.nostar1.Visible = true;
            this.nostar2.Visible = true;
            this.nostar3.Visible = true;
            this.nostar4.Visible = true;
            this.nostar5.Visible = true;
            this.star1.Visible = false;
            this.star2.Visible = false;
            this.star3.Visible = false;
            this.star4.Visible = false;
            this.star5.Visible = false;
            
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            //this.comment.selectionlength = 0;
            //this.comment.selectionstart = 0;
        }
    }
}
