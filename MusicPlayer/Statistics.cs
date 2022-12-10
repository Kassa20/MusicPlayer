using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Statistics
    {
        public Statistics()
        {
 
        }

        public Statistics(ListBox amountPlayed, ListBox mostPlayed, SqlConnection connect)
        {
            connect.Open();

            string maxValsql = "SELECT MAX(timesPlayed) FROM SongTable";

            SqlCommand maxCommand = new SqlCommand(maxValsql, connect);
            object result = maxCommand.ExecuteScalar();

            int max = (int)result;


            string titlesql = "SELECT songTitle FROM SongTable WHERE timesPlayed = ('" + max + "')";

            SqlCommand maxCommand2 = new SqlCommand(titlesql, connect);
            object result2 = maxCommand2.ExecuteScalar();


            string maxSong = (string)result2;


            mostPlayed.Items.Add(maxSong);
            amountPlayed.Items.Add(max);

            connect.Close();
        }

    }
}


