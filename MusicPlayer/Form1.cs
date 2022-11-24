using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form 
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    songs.Items.Add(files[i]);
                }

            }

        }

        private void songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[songs.SelectedIndex];
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
 
            var sort = new Sort(songs, files);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
