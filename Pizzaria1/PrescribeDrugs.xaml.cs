using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Pizzaria1
{
    /// <summary>
    /// Interação lógica para UserControlEscolha.xam
    /// </summary>
    public partial class PrescribeDrugs : UserControl
    {
        public PrescribeDrugs()
        {
            InitializeComponent();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {

            string fname = null;
            string lname = null;

            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();
            MySqlConnection connection3 = new MySqlConnection(connectionString);
            connection3.Open();

            MySqlCommand cmd = new MySqlCommand("insert into prescribeddrugs (id,fname,lname,drugs) values (@id , @fname , @lname , @ward)", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", idnum.Text);

            MySqlCommand retrievefName = new MySqlCommand("select fname from patients where id=@fid", connection3);
            retrievefName.Parameters.Clear();
            retrievefName.Parameters.AddWithValue("@fid", idnum.Text);
            MySqlDataReader reader = retrievefName.ExecuteReader();
            while (reader.Read())
            {
                fname = (string)reader["fname"];
            }
            cmd.Parameters.AddWithValue("@fname", fname);


            MySqlCommand retrievelName = new MySqlCommand("select lname from patients where id=@fid", connection2);
            retrievelName.Parameters.Clear();
            retrievelName.Parameters.AddWithValue("@fid", idnum.Text);
            MySqlDataReader reader1 = retrievelName.ExecuteReader();
            while (reader1.Read())
            {
                lname = (string)reader1["lname"];
            }
            cmd.Parameters.AddWithValue("@lname", lname);


            cmd.Parameters.AddWithValue("@ward", prescription.Text);


            cmd.ExecuteNonQuery();

            connection.Close();

            Prescribed ts = new Prescribed();
            ts.Show();

        }
    }
}
