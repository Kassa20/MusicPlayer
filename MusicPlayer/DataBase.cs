using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class DataBase
    {

        private ListBox _songs;
        private SqlConnection _connect;

        public ListBox Songs { get => _songs; set => _songs = value; }
        public SqlConnection Connect { get => _connect; set => _connect = value; }

        public DataBase(ListBox songs, SqlConnection connect)
        {
            Songs = songs;
            Connect = connect;
        }


        public void updateDataBase()
        {
            int i = 1;

            Connect.Open();
            string curItem = Songs.SelectedItem.ToString();

            try
            {

                string sql = "SELECT SongTitle FROM SongTable WHERE songTitle = ('" + curItem + "')";

                SqlCommand cmd2 = new SqlCommand(sql, Connect);
                object result = cmd2.ExecuteScalar();

                string value = (string)result;


                if (!value.Equals(curItem))
                {
                    string query = "Insert into SongTable values ('" + curItem + "', '" + i + "') ";

                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                }



                string update = "UPDATE SongTable SET timesPlayed = timesPlayed + 1 WHERE songTitle = ('" + curItem + "')";
                SqlCommand updatecmd = new SqlCommand(update, Connect);

                int rowsAffected = updatecmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                string query = "Insert into SongTable values ('" + curItem + "', '" + i + "') ";

                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
            }

            Connect.Close();
        }


    }
}

