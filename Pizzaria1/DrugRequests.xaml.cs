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
using System.Windows.Controls;
using System.Speech.Synthesis;
using MySql.Data.MySqlClient;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for PatientQueue.xaml
    /// </summary>
    public partial class DrugRequests : UserControl
    {

        SpeechSynthesizer talk = new SpeechSynthesizer();
        public static DataGrid datagrid;

        public DrugRequests()
        {
            InitializeComponent();
            DataContext = this;

            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand retrieveQueue = new MySqlCommand("select id,fname,lname from prescribeddrugs", connection);
            MySqlDataReader reader = retrieveQueue.ExecuteReader();

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(reader);
            //myDataGrid.ItemsSource = dt.DefaultView;

            List<System.Data.DataRow> dr = dt.Rows.Cast<System.Data.DataRow>().ToList();

            List<System.Data.DataRow> dr2 = new List<System.Data.DataRow>(dt.Select());



            myDataGrid.ItemsSource = dt.Select().ToList();
            myDataGrid.ItemsSource = dt.DefaultView;



            /*
            while (reader.Read())
            {
                //string id = (string)reader["id"];
                string fname = (string)reader["fname"];
                string lname = (string)reader["fname"];

                
              

                listv.Items.Add(lvitem);
                
            }
            
            */

            connection.Close();
        }

        private void load()
        {

        }

        private void CallBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataRowView row = myDataGrid.SelectedItem as System.Data.DataRowView;
            string name = row.Row.ItemArray[1].ToString() + row.Row.ItemArray[2].ToString();
            talk.Speak(name);
            // MessageBox.Show(row.Row.ItemArray[1].ToString());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;

            RequestDeletePrompt q = new RequestDeletePrompt();
            q.setId(row2.Row.ItemArray[0].ToString());
            q.Show();
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            Drugs cam = new Drugs();
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = cam.Handle;
            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;

            cam.setPid(row2.Row.ItemArray[0].ToString());

            cam.Show();
        }
    }
}
