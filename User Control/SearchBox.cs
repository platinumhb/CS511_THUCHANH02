using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class SearchBox : UserControl
    {
        public event Action<int> SongClicked;
        public int clicked_index;
        public int n = 30;
        public string dirPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/SongInfo/";
        public List<string> nameList;
        public List<string> singerList;
        public object JsonConvert { get; private set; }

        void generate_all_song(int n)
        {
            n = 30;

            for (int i = 1; i <= n; i++)
            {
                SongDemo song = new SongDemo(i);
                song.Name = i.ToString();

                song.SongClicked += song_clicked;
                // Thêm Label vào FlowLayoutPanel
                this.Category.Controls.Add(song);
            }
        }
        public SearchBox()
        {
            InitializeComponent();
            generate_all_song(n);

            nameList = new List<string> { "Nothing" };
            singerList = new List<string> { "Nothing" };

            for (int i = 1; i <= n; i++)
            {
                string fileName = $"Info_{i}.json";
                string filePath = Path.Combine(dirPath, fileName);
                string jsonContent = File.ReadAllText(filePath);
                JObject jsonObject = JObject.Parse(jsonContent);

                string songName = (string)jsonObject["name"];
                string songSinger = (string)jsonObject["singer"];

                nameList.Add(songName);
                singerList.Add(songSinger);

            }
        }

        private void song_clicked(int index)
        {
            this.clicked_index = index;
            this.SongClicked?.Invoke(clicked_index);
        }

        public List<int> match = new List<int>();
        private void search_Click(object sender, EventArgs e)
        {
            string query = this.content.Text;

            if (query == null)
            {
                this.Category.Controls.Clear();
                generate_all_song(30);
            }
            else
            {
                this.Category.Controls.Clear();
                match = new List<int>();

                if (this.nameBtt.Checked == true && this.singerBtt.Checked == false)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (nameList[i].ToLower().Contains(query.ToLower()))
                        {
                            match.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (singerList[i].ToLower().Contains(query.ToLower()))
                        {
                            match.Add(i);
                        }
                    }
                }

                foreach (int index in match)
                {
                    Console.WriteLine(index);
                    SongDemo song = new SongDemo(index);

                    song.SongClicked += song_clicked;
                    // Thêm Label vào FlowLayoutPanel
                    this.Category.Controls.Add(song);
                }
                
            }

        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            if (content.Text.StartsWith(Environment.NewLine))
            {
                // Xóa dấu Enter và đặt lại vị trí con trỏ
                content.Text = content.Text.TrimStart('\r', '\n');
                content.SelectionStart = content.Text.Length;
            }

            if(string.IsNullOrEmpty(content.Text))
            {
                this.Category.Controls.Clear();
                generate_all_song(30);
            }    
        }

        private void content_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string query = this.content.Text;

                if (query == null)
                {
                    this.Category.Controls.Clear();
                    generate_all_song(30);
                }
                else
                {
                    this.Category.Controls.Clear();
                    match = new List<int>();

                    if (this.nameBtt.Checked == true && this.singerBtt.Checked == false)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            if (nameList[i].ToLower().Contains(query.ToLower()))
                            {
                                match.Add(i);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            if (singerList[i].ToLower().Contains(query.ToLower()))
                            {
                                match.Add(i);
                            }
                        }
                    }

                    foreach (int index in match)
                    {
                        Console.WriteLine(index);
                        SongDemo song = new SongDemo(index);

                        song.SongClicked += song_clicked;
                        // Thêm Label vào FlowLayoutPanel
                        this.Category.Controls.Add(song);
                    }
                }
            }
        }
    }
}
