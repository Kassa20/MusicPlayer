using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Sort
    {
        public Sort(ListBox songs, String[] files)
        {
            songs.Items.Clear();
            int j;
            for (j = files.Length - 1; j >= 0; j--)
            {
                songs.Items.Add(files[j]);
            }
        }

    }
}


