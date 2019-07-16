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
using System.Data;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for PatientRecords.xaml
    /// </summary>
    public partial class PatientRecords : UserControl
    {
        SpeechSynthesizer talk = new SpeechSynthesizer();
        
        System.Data.DataTable dt;

        public PatientRecords()
        {
            InitializeComponent();
            DataContext = this;

            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand retrieveQueue = new MySqlCommand("select id,fname,lname,pnumber,address,regdate,image from patients", connection);
            MySqlDataReader reader = retrieveQueue.ExecuteReader();

             dt = new System.Data.DataTable();
            dt.Load(reader);
            

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

       

       

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;
            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();
            MySqlCommand cmd = new MySqlCommand("delete from patientqueue where id=@pid", connection2);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pid", row2.Row.ItemArray[0].ToString());
            cmd.ExecuteNonQuery();
            connection2.Close();
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            HealthRecord cam = new HealthRecord();
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = cam.Handle;
            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;
            
            cam.setPid(row2.Row.ItemArray[0].ToString());
            
            cam.Show();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddHealthRecord cam = new AddHealthRecord();
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = cam.Handle;
            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;

            cam.setPid(row2.Row.ItemArray[0].ToString());

            cam.Show();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataView dv = new DataView(dt);
            
            dv.RowFilter = string.Format("fname LIKE '%{0}%'", searchBox.Text);
            myDataGrid.ItemsSource = dv;
        }
    }
}
