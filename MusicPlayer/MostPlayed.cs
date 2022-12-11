using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MostPlayed : Form
    {
        public MostPlayed()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DSU\\OneDrive\\Documents\\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void mostPlayedSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void display_Click(object sender, EventArgs e)
        {
            var stats = new Statistics(amountPlayed, mostPlayedSongs, connect);
            stats.mostPlayedsong();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
