using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class MusicInfo : UserControl
    {
        public MusicInfo()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MusicInfo_Load(object sender, EventArgs e)
        {
            string dirPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/SongInfo/";
            // Đường dẫn tới thư mục chứa các tệp JSON

            // Tạo tên tệp dựa trên giá trị i
            string fileName = $"Info_{2}.json";

            // Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);

            try
            {
                // Đọc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                // Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                // Lấy giá trị của trường "name"
                string songName = (string)jsonObject["name"];
                string songSinger = (string)jsonObject["singer"];
                string imagePath = (string)jsonObject["image_dir"];
                string songLyric = (string)jsonObject["lyric"];

                //// Hiển thị giá trị trong Console (bạn có thể bỏ qua bước này nếu không cần)
                //Console.WriteLine($"Song Name: {imagePath}");

                this.lyric.Text = songLyric;
                //this.SongName.Text = songName;
                //this.Singer.Text = songSinger;
                //this.SongImage.Image = Image.FromFile(imagePath);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
