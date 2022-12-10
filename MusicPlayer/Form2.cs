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
    public partial class Form2 : Form
    {
        public Form2()
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

        }
    }
}
