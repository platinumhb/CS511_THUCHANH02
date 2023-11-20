using LAB02.User_Control;
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

namespace LAB02
{
    public partial class HomePage : Form
    {
        public int clicked_index;
        public int loved_index;
        public int count_playlist = 0;
        public bool loved_check;
        public MusicInfo musicInfo;
        public string previous = "null";
        public string next = "main";
        public List<int> fav = new List<int>();
        List<PlaylistInfo> Playlists = new List<PlaylistInfo>();
        Playlist newPlaylist;
        public string history_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/History.txt";
        public string favorite_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Favorite.txt";
        public string playlist_path = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Playlist/";
        public BindingList<int> history = new BindingList<int>();
        public class PlaylistInfo
        {
            public Label Label { get; set; }
            public Playlist Playlist { get; set; }
        }
        public HomePage()
        {
            File.WriteAllText(history_path, string.Empty);
            File.WriteAllText(favorite_path, string.Empty);

            // Dọn các playlist cũ
            string[] files = Directory.GetFiles(playlist_path);
            foreach (string file in files)
            {
                File.Delete(file);
                Console.WriteLine($"Đã xóa file: {file}");
            }

            Playlists = new List<PlaylistInfo>();
            Playlists.Add(new PlaylistInfo());
            InitializeComponent();
            //this.history_list = new History(history_path);
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
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;

            main.PanelClickedvn += main_listvn_clicked;
            main.PanelClickednn += main_listnn_clicked;
            
            // Song click event
            enCategory.SongClicked += EnCategory_SongClicked;
            vnCategory.SongClicked += VNCategory_SongClicked;
            main.SongClicked += MainCategory_SongClicked;
            searchBox.SongClicked += Querry_SongClicked;

            //Love event
            vnCategory.LoveChanged += VNCategory_LoveChanged;
            main.LoveChanged += MainCategory_LoveChanged;
            enCategory.LoveChanged += EnCategory_LoveChanged;
            //searchBox.SongClicked += Querry_SongClicked;
        }

        private void Main_PanelClickednn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nhacVN_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "vnCategory";
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if(this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            if (this.newplaylist != null)
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
            }
        }    
        private void nhacNN_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "enCategory";
            this.enCategory.Visible = true;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            if (this.newplaylist != null)
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
            }
        }
        private void home_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "main";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = true;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            if (this.newplaylist != null)
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
            }
        }
        private void main_listvn_clicked(object sender, EventArgs e)
        {
            previous = "main";
            next = "vnCategory";
            this.vnCategory.Visible = true;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            if (this.newplaylist != null)
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
            }
        }
        private void main_listnn_clicked(object sender, EventArgs e)
        {
            previous = "main";
            next = "enCategory";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = true;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            if (this.newplaylist != null)
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
            }
        }

        // Click event
        private void EnCategory_SongClicked(int index)
        {
            this.clicked_index = index;
            this.history.Add(index);
            musicInfo = new MusicInfo(this.clicked_index, this.Playlists);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);   
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";

            bool originalVisible = history_list.Visible;
            Point originalLocation = history_list.Location;
            using (StreamWriter writer = new StreamWriter(history_path, true))
            {            
                writer.WriteLine(index);
            }
            history_list = new History();
            history_list.Visible = false;
            history_list.Location = originalLocation;
            this.Controls.Add(history_list);
        }
        private void VNCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            this.history.Add(clicked_index);
            musicInfo = new MusicInfo(this.clicked_index, this.Playlists);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";

            bool originalVisible = history_list.Visible;
            Point originalLocation = history_list.Location;
            using (StreamWriter writer = new StreamWriter(history_path, true))
            {              
                writer.WriteLine(index);       
            }
            history_list = new History();
            history_list.Visible = false;
            history_list.Location = originalLocation;
            this.Controls.Add(history_list);
        }
        private void MainCategory_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            this.history.Add(clicked_index);
            musicInfo = new MusicInfo(this.clicked_index, this.Playlists);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";

            bool originalVisible = history_list.Visible;
            Point originalLocation = history_list.Location;
            using (StreamWriter writer = new StreamWriter(history_path, true))
            {
                writer.WriteLine(index);             
            }
            history_list = new History();
            history_list.Location = originalLocation;
            history_list.Visible = false;
            this.Controls.Add(history_list);
        }
        private void Querry_SongClicked(int index)
        {
            // Xử lý khi có sự kiện click từ ENCategory
            // Cập nhật giá trị current của MainForm
            this.clicked_index = index;
            this.history.Add(clicked_index);
            musicInfo = new MusicInfo(this.clicked_index, this.Playlists);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";

            bool originalVisible = history_list.Visible;
            Point originalLocation = history_list.Location;
            using (StreamWriter writer = new StreamWriter(history_path, true))
            {
                writer.WriteLine(index);
            }
            history_list = new History();
            history_list.Location = originalLocation;
            history_list.Visible = false;
            this.Controls.Add(history_list);
        }
        private void Favorite_SongClicked(int index)
        {
            this.clicked_index = index;
            musicInfo = new MusicInfo(this.clicked_index, this.Playlists);

            musicInfo.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            this.musicInfo.Visible = true;
            this.Controls.Add(musicInfo);
            musicInfo.BringToFront();

            previous = next;
            next = "musicInfo";
        }
        private void MainCategory_LoveChanged(bool love_check, int love_index)
        {
            // Update lại dữ liệu
            if (love_check == true)
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());
                if (!objectExists)
                {
                    using (StreamWriter writer = new StreamWriter(favorite_path, true))
                    {
                        writer.WriteLine(love_index);
                    }
                }
            }
            else
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());

                if (objectExists)
                {
                    string[] updatedLines = lines.Where(line => line.Trim() != love_index.ToString()).ToArray();

                    // Ghi lại dữ liệu vào tệp tin
                    File.WriteAllLines(favorite_path, updatedLines);
                }
            }
            bool originalVisible = this.favorite.Visible;
            Point originalLocation = this.favorite.Location;
            favorite = new Favorite();
            favorite.Location = originalLocation;
            favorite.Visible = originalVisible;
            this.Controls.Add(favorite);
        }
        private void EnCategory_LoveChanged(bool love_check, int love_index)
        {
            // Update lại dữ liệu
            if (love_check == true)
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());
                if (!objectExists)
                {
                    using (StreamWriter writer = new StreamWriter(favorite_path, true))
                    {
                        writer.WriteLine(love_index);
                    }
                }
            }
            else
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());

                if (objectExists)
                {
                    string[] updatedLines = lines.Where(line => line.Trim() != love_index.ToString()).ToArray();

                    // Ghi lại dữ liệu vào tệp tin
                    File.WriteAllLines(favorite_path, updatedLines);
                }
            }
            bool originalVisible = this.favorite.Visible;
            Point originalLocation = this.favorite.Location;
            favorite = new Favorite();
            favorite.Location = originalLocation;
            favorite.Visible = originalVisible;
            this.Controls.Add(favorite);
        }
        private void VNCategory_LoveChanged(bool love_check, int love_index)
        {
            // Update lại dữ liệu
            if (love_check == true)
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());
                if (!objectExists)
                {
                    using (StreamWriter writer = new StreamWriter(favorite_path, true))
                    {
                        writer.WriteLine(love_index);
                    }
                }
            }
            else
            {
                string[] lines = File.ReadAllLines(favorite_path);

                // Kiểm tra xem đối tượng đã tồn tại hay chưa
                bool objectExists = Array.Exists(lines, line => line.Trim() == love_index.ToString());

                if (objectExists)
                {
                    string[] updatedLines = lines.Where(line => line.Trim() != love_index.ToString()).ToArray();

                    // Ghi lại dữ liệu vào tệp tin
                    File.WriteAllLines(favorite_path, updatedLines);
                }
            }
            bool originalVisible = this.favorite.Visible;
            Point originalLocation = this.favorite.Location;
            favorite = new Favorite();
            favorite.Location = originalLocation;
            favorite.Visible = originalVisible;
            this.Controls.Add(favorite);
        }

        // Back và Next event
        public Label templb;
        private void Back_Click(object sender, EventArgs e)
        {
            if(previous != "newPlaylist")
                this.Controls[previous].Visible = true;
            else
            {
              
                foreach (var playlistInfo in Playlists)
                {
                    if (playlistInfo.Label == backlb)
                        playlistInfo.Playlist.Visible = true;
                    else
                        playlistInfo.Playlist.Visible = false;

                }
                templb = nextlb;
                nextlb = backlb;
                backlb = templb;
            } 
            

            if(next != "newPlaylist")
                this.Controls[next].Visible = false;
            else
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
                templb = nextlb;
                nextlb = backlb;
                backlb = templb;
            }

            string temp = next;
            next = previous;
            previous = temp;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (next != "newPlaylist")
                this.Controls[next].Visible = true;
            else
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    if (playlistInfo.Label == nextlb)
                        playlistInfo.Playlist.Visible = true;
                    else
                        playlistInfo.Playlist.Visible = false;
                }
                templb = nextlb;
                nextlb = backlb;
                backlb = templb;
            }

            
            if (previous != "newPlaylist")
                this.Controls[previous].Visible = false;
            else
            {
                foreach (var playlistInfo in Playlists)
                {
                    // Ẩn Playlist
                    playlistInfo.Playlist.Visible = false;
                }
                templb = nextlb;
                nextlb = backlb;
                backlb = templb;
            }

            string temp = next;
            next = previous;
            previous = temp;
        }
        
        // Lại là click ẩn/hiện event
        private void search_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "searchBox";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = true;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
        }
        private void searchicon_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "searchBox";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = true;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
        }
        private void love_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "favorite";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = true;
            this.history_list.Visible = false;
        }
        private void loveic_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "favorite";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = true;
            this.history_list.Visible = false;
        }
        private void his_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "history_list";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = true;
        }
        private void hisicon_Click(object sender, EventArgs e)
        {
            previous = next;
            next = "history_list";
            this.vnCategory.Visible = false;
            this.enCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = true;
        }

        public Label backlb;
        public Label nextlb;
        
        private void newplaylist_Click(object sender, EventArgs e)
        {
            count_playlist += 1;
            string plname = $"Playlist {count_playlist}";
            string filePath = Path.Combine(playlist_path, $"{count_playlist}.txt");

            // Code tạo file và thêm playlist usercontrol ở đây...
            //Check xem file có tồn tại không, nếu không thì tạo
            if (!File.Exists(filePath))
            {
                // Tạo file mới và mở nó để ghi
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // Ghi nội dung vào file
                    sw.WriteLine("");
                }
            }

            // Thêm playlist usercontrol
            newPlaylist = new Playlist(count_playlist);
            newPlaylist.Location = new Point(188, 50);

            // Thực hiện các công việc cập nhật khác nếu cần
            newPlaylist.Visible = true;
            newPlaylist.BringToFront();

            // Thêm label mới tượng trưng cho playlist
            Label newLabel = new Label();
            newLabel.Name = $"playlist{count_playlist}";
            newLabel.Text = plname;
            newLabel.ForeColor = Color.White;
            newLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            newLabel.Padding = new Padding(20, 0, 0, 0);

            playlistpanel.Controls.Add(newLabel);
            newLabel.Click += Label_Click;

            // Thêm vô danh sách
            PlaylistInfo playlistInfo = new PlaylistInfo
            {
                Label = newLabel,
                Playlist = newPlaylist
            };
            HideAllUserControls();
            Playlists.Add(playlistInfo);
            this.Controls.Add(playlistInfo.Playlist);
            // Các công việc khác ở đây...
        }

        private void Label_Click(object sender, EventArgs e)
        {
            // Ẩn các UserControl khác
            HideAllUserControls();

            // Hiển thị UserControl Playlist tương ứng với Label được click
            if (sender is Label clickedLabel)
            {
                // Tìm PlaylistInfo tương ứng với Label được click
                PlaylistInfo clickedPlaylistInfo = Playlists.FirstOrDefault(p => p.Label == clickedLabel);

                if (clickedPlaylistInfo != null)
                {
                    clickedPlaylistInfo.Playlist.Visible = true;
                    nextlb = clickedPlaylistInfo.Label;
                }
            }

            // Các công việc khác ở đây...
        }

        private void HideAllUserControls()
        {
            this.enCategory.Visible = false;
            this.vnCategory.Visible = false;
            this.main.Visible = false;
            if (this.musicInfo != null)
                this.musicInfo.Visible = false;
            this.searchBox.Visible = false;
            this.favorite.Visible = false;
            this.history_list.Visible = false;
            //if(Playlists != null)
            //    foreach (var playlistInfo in Playlists)
            //    {
            //        // Ẩn tất cả các Playlist
            //        playlistInfo.Playlist.Visible = false;
            //    }
        }
        //public void UpdateLabel(int rnindex, string newname)
        //{
        //    foreach (var playlistInfo in Playlists)
        //    {
        //        // Kiểm tra null cho playlistInfo
        //        if (playlistInfo != null)
        //        {
        //            if (playlistInfo.Playlist.Index == rnindex)
        //            {
        //                playlistInfo.Label.Text = newname;
        //                Console.WriteLine($"Đã cập nhật tên của Playlist có Index {rnindex} thành {newname}");
        //            }
        //        }

        //    }
        //}
    }

}
