using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LAB02.User_Control
{
    public partial class MusicPlayer : UserControl
    {
        public int Index;
        string songPath = "D:/STUDYING/3rd Year 2023_2024/CS551 - Ngôn ngữ lập trình C#/CS551_THUCHANH02/LAB02/Database/Song/";
        string mp3FileName;
        string mp3filePath;
        public WindowsMediaPlayer mediaPlayer;  
        bool begin = false;
        public MusicPlayer()
        {
            InitializeComponent();
            //this.Index = index;                       
            
            pBar.MouseClick += pBar_Click;
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            this.Play.Visible = true;
            this.Stop.Visible = false;

            mediaPlayer = new WindowsMediaPlayer();
            mp3FileName = $"Song_{Index}.mp3";
            mp3filePath = System.IO.Path.Combine(songPath, mp3FileName);

            mediaPlayer.URL = mp3filePath;
            mediaPlayer.controls.stop();

            timer1.Interval = 1000;

            // Bật timer
            timer1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.Play.Visible = true;
            this.Stop.Visible = false;

            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                mediaPlayer.controls.pause();
                Console.WriteLine("Đã tạm dừng nhạc");
            }
            timer1.Stop();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Play.Visible = false;
            this.Stop.Visible = true;

            if(begin == false)
            {
                try
                {
                    mediaPlayer.controls.play();
                    Console.WriteLine($"Đã phát file MP3: {mp3filePath}");
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi phát file MP3: {ex.Message}");
                }
                begin = true;
            } 
            else
            {
                if (mediaPlayer.playState == WMPPlayState.wmppsPaused)
                {
                    mediaPlayer.controls.play();
                    timer1.Start();
                    Console.WriteLine("Tiếp tục phát nhạc");
                }
            }    
         
            
        }


        public void ReceiveIndex(int index)
        {
            Index = index;

            // Thực hiện các công việc cần thiết với giá trị index tại đây
            // Ví dụ:
            // labelIndex.Text = $"Received Index: {receivedIndex}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(mediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                double currentPosition = mediaPlayer.controls.currentPosition;

                // Lấy tổng thời gian của bài hát
                double totalDuration = mediaPlayer.currentMedia.duration;

                // Tính toán phần trăm tiến độ
                int progressPercentage = (int)((currentPosition / totalDuration) * 100);

                // Cập nhật giá trị của progress bar
                pBar.Value = progressPercentage;
            }    
        }

        private void pBar_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Your existing code...

                // Lấy tọa độ x của sự kiện click
                int clickX = e.X;

                // Lấy tổng chiều dài của progress bar
                int totalWidth = pBar.Width;

                // Tính toán phần trăm dựa trên tọa độ click
                double percentage = (double)clickX / totalWidth;

                // Lấy thời điểm tương ứng trong bài hát
                double newPosition = mediaPlayer.currentMedia.duration * percentage;

                // Đặt thời điểm mới cho bài hát
                mediaPlayer.controls.currentPosition = newPosition;
            }
        }
    }
}
