using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02.User_Control
{
    public partial class MusicPlayer : UserControl
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            Audio.Visible = true;
            NoAudio.Visible = false;
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            Audio.Visible = false;
            NoAudio.Visible = true;
        }

        private void NoAudio_Click(object sender, EventArgs e)
        {
            NoAudio.Visible = false;
            Audio.Visible = true; 
        }
    }
}
