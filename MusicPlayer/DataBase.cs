using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class DataBase
    {
        public DataBase(ListBox songs)
        {
            Hashtable ht = new Hashtable();
            int count = 1;

            string curItem = songs.SelectedItem.ToString();
            int index = songs.FindString(curItem);

            if(!ht.Contains(curItem))
            {
                ht.Add(curItem, count);
            }



        }
    }
}
