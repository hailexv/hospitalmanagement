using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class Drugs : Window
    {

        private string pid;
        System.Data.DataTable dt;
        System.Data.DataTable dt2;
        public Drugs()
        {


            InitializeComponent();
            DataContext = this;

            System.Data.DataRowView row2 = myDataGrid.SelectedItem as System.Data.DataRowView;




        }

        public void setPid(string s)
        {
            this.pid = s;


            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();

            MySqlCommand retrieveQueue = new MySqlCommand("select * from prescribeddrugs where id=@pid", connection);
            retrieveQueue.Parameters.Add("@pid", MySqlDbType.Int32, 100);
            retrieveQueue.Parameters["@pid"].Value = pid;



            MySqlDataReader reader = retrieveQueue.ExecuteReader();

            dt = new System.Data.DataTable();
            dt.Load(reader);

            //myDataGrid.ItemsSource = dt.DefaultView;

            List<System.Data.DataRow> dr = dt.Rows.Cast<System.Data.DataRow>().ToList();
            List<System.Data.DataRow> dr2 = new List<System.Data.DataRow>(dt.Select());

            myDataGrid.ItemsSource = dt.Select().ToList();
            myDataGrid.ItemsSource = dt.DefaultView;



            MySqlCommand retrieveImage = new MySqlCommand("select image from patients where id=@pid", connection2);


            retrieveImage.Parameters.Clear();
            retrieveImage.Parameters.AddWithValue("@pid", s);
            MySqlDataReader reader1 = retrieveImage.ExecuteReader();

            dt2 = new System.Data.DataTable();
            dt2.Load(reader1);
            //myDataGrid.ItemsSource = dt.DefaultView;




            myImage.ItemsSource = dt2.Select().ToList();
            myImage.ItemsSource = dt2.DefaultView;


        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DonateButton_OnClick(object sender, RoutedEventArgs e)
        {
            string fileName;
            Spire.DataExport.XLS.CellExport cellExport = new Spire.DataExport.XLS.CellExport();
            Spire.DataExport.XLS.WorkSheet worksheet1 = new Spire.DataExport.XLS.WorkSheet();
            worksheet1.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
            worksheet1.DataTable = dt;
            worksheet1.StartDataCol = ((System.Byte)(0));
            cellExport.Sheets.Add(worksheet1);
            cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            fileName = "henokxv.xls";
            cellExport.SaveToFile(fileName);
        }
    }
}
