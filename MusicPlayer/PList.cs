using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer
{
    public class PList
    {

        private string[] _files;
        private ListBox _playlist;
        private ListBox _songs;

        public string[] Files { get => _files; set => _files = value; }
        public ListBox Playlist { get => _playlist; set => _playlist = value; }
        public ListBox Songs { get => _songs; set => _songs = value; }


        public PList(String[] files, ListBox playlist, ListBox songs)
        {
            Files = files;
            Playlist = playlist;
            Songs = songs;
        }

        public void addToPlaylist()
        {

            try
            {
                string curItem = Songs.SelectedItem.ToString();
                int index = Songs.FindString(curItem);
                Playlist.Items.Add(Songs.Items[index]);
            }

            catch (Exception e)
            {
                MessageBox.Show("Songlist is Empty!");
            }
        }

        public void clearPlayList(ListBox playlist)
        {
            playlist.Items.Clear();
        }
    }
}
