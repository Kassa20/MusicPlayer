using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class DataBase
    {
        public DataBase(ListBox songs, SqlConnection connect)
        {
            int i = 1;

            connect.Open();
            string curItem = songs.SelectedItem.ToString();



            var cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SongTable where songTitle='" + curItem + "'";

            

            if (!connect.Database.Contains(curItem))
            {
                string query = "Insert into SongTable values ('" + curItem + "', '" + i + "') ";

                SqlCommand cmmd = new SqlCommand(query, connect);
                cmmd.ExecuteNonQuery();
            }
            connect.Close();
        }
    }
}

