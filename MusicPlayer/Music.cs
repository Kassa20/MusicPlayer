using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Music
    {
        public Music(ListBox songs, RichTextBox ReadLyrics)
        {
            string curItem = songs.SelectedItem.ToString();
            int index = songs.FindString(curItem);
            string txtFile = "";

            if (curItem == "Gotye - Somebody That I Used To Know (feat. Kimbra) [Official Music Video].mp3")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Lyrics\\" + "Glyrics.txt");
                ReadLyrics.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

    }
}
