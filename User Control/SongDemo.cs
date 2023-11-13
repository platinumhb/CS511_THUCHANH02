using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace LAB02.User_Control
{
    public partial class SongDemo : UserControl
    {
        public object JsonConvert { get; private set; }
        public int index;
        public SongDemo(int i)
        {
            InitializeComponent();
            this.index = i;
        }

        private void SongDemo_Load(object sender, EventArgs e)
        {
            // Đường dẫn đến tệp JSON
            
            string dirPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/SongInfo/";
            // Đường dẫn tới thư mục chứa các tệp JSON

            // Tạo tên tệp dựa trên giá trị i
            string fileName = $"Info_{index}.json";
          
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
                
                //// Hiển thị giá trị trong Console (bạn có thể bỏ qua bước này nếu không cần)
                //Console.WriteLine($"Song Name: {imagePath}");

                this.SongName.Text = songName;
                this.Singer.Text = songSinger;
                this.SongImage.Image = Image.FromFile(imagePath); 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void NotLovePB_Click(object sender, EventArgs e)
        {
            this.NotLovePB.Visible = false;
            this.LovePB.Visible = true;
        }

        private void LovePB_Click(object sender, EventArgs e)
        {
            this.LovePB.Visible = false;
            this.NotLovePB.Visible = true;
        }
    }
}
