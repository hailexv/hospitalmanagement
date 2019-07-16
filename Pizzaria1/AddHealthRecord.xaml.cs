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
using System.Windows.Shapes;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for HealthRecord.xaml
    /// </summary>
    public partial class AddHealthRecord : Window
    {

        private string pid;
        public AddHealthRecord()
        {


            InitializeComponent();
            

        }

        public void setPid(string s)
        {
            this.pid = s;


           
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();

            string previousRecord = "";
            DateTime dateTime = DateTime.UtcNow.Date;
            // + dateTime.ToString("dd/MM/yyyy")

           

            
            

            MySqlCommand retrieveQueue = new MySqlCommand("insert into healthrecord(id , date ,labtype , labresult , disease) values (@pid , @date , @labtype , @labresult , @disease)", connection);

            /*
            retrieveQueue.Parameters.Add("@pid", MySqlDbType.Int32, 100);
            retrieveQueue.Parameters.Add("@datee", MySqlDbType.LongText, 200);
            retrieveQueue.Parameters.Add("@record", MySqlDbType.LongText, 500);
            
            retrieveQueue.Parameters["@pid"].Value = pid;

            DateTime dateTime = DateTime.UtcNow.Date;

            retrieveQueue.Parameters["@datee"].Value = dateTime.ToString("dd/MM/yyyy");
            retrieveQueue.Parameters["@record"].Value = record.Text;

    */
            
            retrieveQueue.Parameters.AddWithValue("@pid", pid);
            retrieveQueue.Parameters.AddWithValue("@date", dpicker.Text);
            retrieveQueue.Parameters.AddWithValue("@labtype", labType.Text);
            if(positiveBtn.IsChecked == true)
            {
                retrieveQueue.Parameters.AddWithValue("@labresult", "POSITIVE");
            }
            else
            {
                retrieveQueue.Parameters.AddWithValue("@labresult", "POSITIVE");
            }
            
            retrieveQueue.Parameters.AddWithValue("@disease", disease.Text);

            retrieveQueue.ExecuteNonQuery();
            
            connection.Close();
            connection2.Close();
        }
    }
}
