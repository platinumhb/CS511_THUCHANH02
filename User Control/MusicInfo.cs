using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Image = System.Drawing.Image;

namespace LAB02.User_Control
{
    public partial class MusicInfo : UserControl
    {
        public object JsonConvert { get; private set; }
        public int index;
        public string dirPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/SongInfo/";
        public MusicInfo(int i)
        {
            InitializeComponent();
            this.index = i;
            Lyric.ScrollBars = RichTextBoxScrollBars.None;
        }

        private void MusicInfo_Load(object sender, EventArgs e)
        {
            // Đường dẫn đến tệp JSON

            //string dirPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/SongInfo/";
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
                string songAuthor = (string)jsonObject["author"];
                string imagePath = (string)jsonObject["image_dir"];
                string lyricPath = (string)jsonObject["lyric"];
                string viewNum = (string)jsonObject["download"];

                //// Hiển thị giá trị trong Console (bạn có thể bỏ qua bước này nếu không cần)
                //Console.WriteLine($"Song Name: {imagePath}");

                this.SongName.Text = songName;
                this.Singer.Text = songSinger;
                this.Author.Text = songAuthor;
                this.viewn.Text = viewNum;
                this.Lyric.Text = File.ReadAllText(lyricPath);
                string[] lines = File.ReadAllLines(lyricPath);
                this.SongImage.Image = Image.FromFile(imagePath);
         

                if (this.index < 17)
                    this.Country.Text = "Việt Nam";
                else
                    this.Country.Text = "Nước ngoài";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            this.Song.AutoScroll = true;
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {
            // Màu sắc cho gradient
            Color color1 = Color.Cyan;
            Color color2 = Color.FromArgb(200, 255, 255);

            // Tạo một đối tượng LinearGradientBrush với màu sắc từ color1 đến color2
            LinearGradientBrush brush = new LinearGradientBrush(
                Header.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Vertical);

            // Vẽ gradient lên panel
            e.Graphics.FillRectangle(brush, Header.ClientRectangle);
        }

        private void cmt_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem dấu Enter có ở đầu không
            if (cmt.Text.StartsWith(Environment.NewLine))
            {
                // Xóa dấu Enter và đặt lại vị trí con trỏ
                cmt.Text = cmt.Text.TrimStart('\r', '\n');
                cmt.SelectionStart = cmt.Text.Length;
            }

        }

        private void cmt_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string dir = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Images/";
                string boyPath = Path.Combine(dir, "boy.png");
                string girlPath = Path.Combine(dir, "girl.png");

                if (e.KeyValue == 13)
                {
                    uctText uct = new uctText(this.cmt.Text);
                    this.CommentBoard.Controls.Add(uct);
              
                    if(boyBtt.Checked == true && girlBtt.Checked == false)
                        uct.Content(cmt.Text, Image.FromFile(boyPath));
                    else
                        uct.Content(cmt.Text, Image.FromFile(girlPath));

                    //uct.Location = new System.Drawing.Point(0, y);
                    //uct.Size = new System.Drawing.Size(700, 51);
                    //y = y + 50;
                    this.cmt.Clear();
                    this.cmt.SelectionStart = 0;
                    this.cmt.SelectionLength = 0;
                }

            }

        }
    }
}
