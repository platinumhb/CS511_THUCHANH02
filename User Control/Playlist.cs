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
    //public event EventHandler<string> NewFileCreated;
    //public event EventHandler<string> FileRenamed;
    //public event EventHandler<string> FileContentUpdated;
    //public event EventHandler<string> FileDeleted;
    public partial class Playlist : UserControl
    {
        public int Index;
        public Playlist(int i = 1)
        {
            InitializeComponent();
        }

        private void renameBtt_Click(object sender, EventArgs e)
        {
            // Tự động chọn toàn bộ nội dung trong TextBox để dễ dàng việc nhập liệu mới
            namelb.Visible = false;
            nametb.Text = namelb.Text;
            nametb.Visible = true;


            // Chọn toàn bộ nội dung trong TextBox
            nametb.SelectAll();
            nametb.Focus();

            // Gắn sự kiện xử lý khi nhấn Enter
            nametb.KeyDown += nametb_KeyDown;
        }

        private void nametb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ẩn TextBox và hiện lại Label với tên mới
                namelb.Text = nametb.Text;
                nametb.Visible = false;
                namelb.Visible = true;

//(ParentForm as HomePage)?.UpdateLabel(this.Index, nametb.Text);
                // Gỡ bỏ sự kiện xử lý khi nhấn Enter
                nametb.KeyDown -= nametb_KeyDown;
            }
        }
    }

   
}
