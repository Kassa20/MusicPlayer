using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Music
    {
        private ListBox _songs;
        private RichTextBox _readLyrics;

        public ListBox Songs { get => _songs; set => _songs = value; }
        public RichTextBox ReadLyrics { get => _readLyrics; set => _readLyrics = value; }

        public Music(ListBox songs, RichTextBox readLyrics)
        {
            Songs = songs;
            ReadLyrics = readLyrics;
        }

        public void readSongs()
        {
            string curItem = Songs.SelectedItem.ToString();
            int index = Songs.FindString(curItem);
            string txtFile = "";

            if (curItem == "Gotye - Somebody That I Used To Know (feat. Kimbra) [Official Music Video].mp3")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Lyrics\\" + "Glyrics.txt");
                ReadLyrics.Text = sr.ReadToEnd();
                sr.Close();
            }

            else if (curItem == "The Way You Make Me Feel (2012 Remaster).mp3")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Lyrics\\" + "Mlyrics.txt");
                ReadLyrics.Text = sr.ReadToEnd();
                sr.Close();
            }

            else if (curItem == "You Rock My World.mp3")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Lyrics\\" + "Rlyrics.txt");
                ReadLyrics.Text = sr.ReadToEnd();
                sr.Close();
            }

            else if (curItem == "Fleetwood Mac - Dreams [with lyrics].mp3")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Lyrics\\" + "Flyrics.txt");
                ReadLyrics.Text = sr.ReadToEnd();
                sr.Close();
            }
        }


        }
}
