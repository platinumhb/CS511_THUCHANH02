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
using System.Reflection;

namespace LAB02.User_Control
{
    public partial class SongDemo : UserControl
    {
        public object JsonConvert { get; private set; }
        public event Action<int> SongClicked;
        public event Action<bool, int> LoveChanged;
        public string favorite_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Favorite.txt";

        public int index;
        public bool loved_check;
        public SongDemo(int i)
        {
            InitializeComponent();            
            this.index = i;

            // Đọc tất cả các dòng từ tệp tin
            string[] lines = File.ReadAllLines(favorite_path);
            // Kiểm tra xem đối tượng đã tồn tại hay chưa
            bool objectExists = Array.Exists(lines, line => line.Trim() == this.index.ToString());
       

            if (objectExists)
            {
                // Nếu đối tượng đã tồn tại, thêm vào tệp tin
                this.loved_check = true;
            }
            else 
                this.loved_check = false;

            
     
            if(loved_check == true)
            {
                this.NotLovePB.Visible = false;
                this.LovePB.Visible = true;
            }
            else
            { 
                this.LovePB.Visible = false;
                this.NotLovePB.Visible = true;
            } 
            
        }

        private void SongDemo_Load(object sender, EventArgs e)
        {
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
            loved_check = true;
            LoveChanged?.Invoke(this.loved_check, this.index);
        }

        private void LovePB_Click(object sender, EventArgs e)
        {
            this.LovePB.Visible = false;
            this.NotLovePB.Visible = true;
            loved_check = false;
            LoveChanged?.Invoke(this.loved_check, this.index);
        }

        private void SongImage_Click(object sender, EventArgs e)
        {
            SongClicked?.Invoke(this.index);
        }

        private void SongName_Click(object sender, EventArgs e)
        {
            SongClicked?.Invoke(this.index);
        }

        private void Singer_Click(object sender, EventArgs e)
        {
            SongClicked?.Invoke(this.index);
        }

        private void SongDemo_Click(object sender, EventArgs e)
        {
            SongClicked?.Invoke(this.index);
        }
    }
}
