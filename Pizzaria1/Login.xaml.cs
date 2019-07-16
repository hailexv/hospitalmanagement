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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            

            MySqlCommand cmd = new MySqlCommand("select id from users where name=@usr and password=@pwd",connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", usernameBox.Text);
            cmd.Parameters.AddWithValue("@pwd", FloatingPasswordBox.Password);
            connection.Open();


            object result = cmd.ExecuteScalar();
            try
            {


                if (int.Parse(result.ToString()) > 1)
                {

                    if (usernameBox.Text == "cashier")
                    {
                        MainWindow m = new MainWindow();
                        this.Close();
                        m.Show();

                    }
                    else if (FloatingPasswordBox.Password == "doctor")
                    {
                        DoctorWindow dw = new DoctorWindow();
                        this.Close();
                        dw.Show();
                    }
                    else
                    {
                        PharmacistWindow pw = new PharmacistWindow();
                        this.Close();
                        pw.Show();
                    }



                }

            }

            catch (Exception x)
            {
                MessageBox.Show("Incorrect Password");
            }
            

            connection.Close();

           
        }
    }
}
