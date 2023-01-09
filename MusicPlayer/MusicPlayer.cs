using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form 
    {
        public MusicPlayer()
        {
            InitializeComponent();
            mediaPlayer.settings.autoStart = false;
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DSU\\OneDrive\\Documents\\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        String[] paths, files;


        private void songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mediaPlayer.URL = paths[songs.SelectedIndex];
            }

            catch(Exception ex)
            {   
                MessageBox.Show("Select a song and click play");
            }

        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    songs.Items.Add(files[i]);
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }


        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.URL = paths[playList.SelectedIndex];

        }

        private void AddPlaylist_Click(object sender, EventArgs e)
        {
            var newPlaylist = new PList(files, playList, songs);
            newPlaylist.addToPlaylist();
        }

        private void clearPlayList_Click(object sender, EventArgs e)
        {
            var clear = new PList(files, playList, songs);
            clear.clearPlayList(playList);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaPlayer.Ctlcontrols.play();
                var music = new Music(songs, ReadLyrics);
                var database = new DataBase(songs, connect);
                music.readSongs();
                database.updateDataBase();
            }

            catch(Exception p)
            {
                MessageBox.Show("No song to Play!");
            }

        }


        private void MostPlayedbutton_Click(object sender, EventArgs e)
        {
            var st = new MostPlayed();
            st.ShowDialog();
        }


        private void ReadLyrics_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
