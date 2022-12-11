using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Statistics
    {


        private ListBox _amountPlayed;
        private ListBox _mostPlayed;
        private SqlConnection _connect;
        private int _max;
        private string _maxSong;


        public ListBox AmountPlayed { get => _amountPlayed; set => _amountPlayed = value; }
        public ListBox MostPlayed { get => _mostPlayed; set => _mostPlayed = value; }
        public SqlConnection Connect { get => _connect; set => _connect = value; }
        public int Max { get => _max; set => _max = value; }
        public string MaxSong { get => _maxSong; set => _maxSong = value; }

        public Statistics(ListBox amountPlayed, ListBox mostPlayed, SqlConnection connect)
        {
            _amountPlayed = amountPlayed;
            _mostPlayed = mostPlayed;
            Connect = connect;
        }


        public void mostPlayedsong()
        {
            Connect.Open();

            string maxValsql = "SELECT MAX(timesPlayed) FROM SongTable";

            SqlCommand maxCommand = new SqlCommand(maxValsql, Connect);
            object result = maxCommand.ExecuteScalar();

            _max = (int)result;


            string titlesql = "SELECT songTitle FROM SongTable WHERE timesPlayed = ('" + _max + "')";

            SqlCommand maxCommand2 = new SqlCommand(titlesql, Connect);
            object result2 = maxCommand2.ExecuteScalar();


            _maxSong = (string)result2;


            _mostPlayed.Items.Add(_maxSong);
            _amountPlayed.Items.Add(_max);

            Connect.Close();
        }

    }
}


