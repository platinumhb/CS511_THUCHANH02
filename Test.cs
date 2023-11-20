using LAB02.User_Control;
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

namespace LAB02
{
    public partial class Test : Form
    {
        public int clicked_index;
        public string playlist_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Playlist/";
        public string favorite_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Favorite.txt";
        //private List<Playlist> Playlists;
        public int count_playlist = 0;
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
        }
        private Label nameLabel;
        private TextBox renameTextBox;
        private Button confirmRenameButton;

        // Các phương thức và thuộc tính khác của Playlist...

        private void InitializeComponents()
        {
            // Khởi tạo các thành phần UI tại đây...

            nameLabel = new Label();
            nameLabel.Name = "nameLabel";
            nameLabel.Text = "Playlist Name";
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Padding = new Padding(20, 0, 0, 0);

            renameTextBox = new TextBox();
            renameTextBox.Name = "renameTextBox";
            renameTextBox.Visible = false;

            confirmRenameButton = new Button();
            confirmRenameButton.Name = "confirmRenameButton";
            confirmRenameButton.Text = "OK";
            confirmRenameButton.Visible = false;
            confirmRenameButton.Click += ConfirmRenameButton_Click;

            Controls.Add(nameLabel);
            Controls.Add(renameTextBox);
            Controls.Add(confirmRenameButton);
        }

        private void ConfirmRenameButton_Click(object sender, EventArgs e)
        {
            nameLabel.Text = renameTextBox.Text;
            nameLabel.Visible = true;
            renameTextBox.Visible = false;
            confirmRenameButton.Visible = false;
        }

        private void RenameButtonClick(object sender, EventArgs e)
        {
            nameLabel.Visible = false;
            renameTextBox.Visible = true;
            confirmRenameButton.Visible = true;
        }
    }
}
