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
        public Sort(ListBox playlist, String[] files)
        {
            playlist.Items.Clear();
            int j = files.Length-1;
            for (int i = 0; i < files.Length; i++)
            {
                playlist.Items.Add(files[j]);
                j--;
            }
        }


    }
}


