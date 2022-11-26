using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class PList
    {
        public PList(String[] files, ListBox playlist, ListBox songs)
        {
            string curItem = songs.SelectedItem.ToString();
            int index = songs.FindString(curItem);
            playlist.Items.Add(songs.Items[index]);
        }
        public void clearPlayList(ListBox playlist)
        {
            playlist.Items.Clear();
        }
    }
}
