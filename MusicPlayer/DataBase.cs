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

            try
            {

                string sql = "SELECT SongTitle FROM SongTable WHERE songTitle = ('" + curItem + "')";

                SqlCommand cmd2 = new SqlCommand(sql, connect);
                object result = cmd2.ExecuteScalar();

                string value = (string)result;


                if (!value.Equals(curItem))
                {
                    string query = "Insert into SongTable values ('" + curItem + "', '" + i + "') ";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }



                string update = "UPDATE SongTable SET timesPlayed = timesPlayed + 1 WHERE songTitle = ('" + curItem + "')";
                SqlCommand updatecmd = new SqlCommand(update, connect);

                int rowsAffected = updatecmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                string query = "Insert into SongTable values ('" + curItem + "', '" + i + "') ";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }


            connect.Close();
        }
    }
}

