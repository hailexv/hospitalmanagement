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
    /// Interação lógica para UserControlInicio.xam
    /// </summary>
    public partial class UserControlInicio : UserControl
    {

        private string capturedPhoto;
        public UserControlInicio()
        {
            InitializeComponent();
            
        }

       
        public void setCapturedPhoto(string s)
        {
            capturedPhoto = s;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            byte[] imageData;
            FileStream fs;
            BufferedStream bf;
            BinaryReader br;

            string fileName = capturedPhoto;
            
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)fs.Length);
            //bf = new BufferedStream(fs);
            //byte[] imgByteArr = new byte[fs.Length];
            //fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            br.Close();
            fs.Close();

            
          

            /*
            br = new BinaryReader(fs);x
            imageData = br.ReadBytes((int)fs.Length);
            
            br.Close();
            fs.Close();
            */


            string connectionString = "SERVER=localhost;DATABASE=hospitalmanagement;UID=root;PASSWORD=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            /*

            MySqlCommand cmd = new MySqlCommand("INSERT INTO patients(id,fname,lname,pnumber,address,regdate,image) " +
                                "VALUES('" + idnum.Text + "', '" + fname.Text + "', '" + lname.Text + "', '" +
                                pnumber.Text + "', '" + addr.Text + "', '" + dpicker.Text + "' , '" + imgByteArr + "') ;", connection);
            */
            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO patients(id,fname,lname,pnumber,address,regdate,image) VALUES (@id,@fname,@lname,@pnumber,@address,@regdate,@image)",connection);
            cmd2.Parameters.Add("@id", MySqlDbType.Int32, 100);
            cmd2.Parameters.Add("@fname", MySqlDbType.VarChar, 100);
            cmd2.Parameters.Add("@lname", MySqlDbType.VarChar, 100);
            cmd2.Parameters.Add("@pnumber", MySqlDbType.VarChar, 100);
            cmd2.Parameters.Add("@address", MySqlDbType.VarChar, 100);
            cmd2.Parameters.Add("@regdate", MySqlDbType.VarChar, 100);
            cmd2.Parameters.Add("@image", MySqlDbType.Blob);

            cmd2.Parameters["@id"].Value = idnum.Text;
            cmd2.Parameters["@fname"].Value = fname.Text.ToString();
            cmd2.Parameters["@lname"].Value = lname.Text.ToString();
            cmd2.Parameters["@pnumber"].Value = pnumber.Text.ToString();
            cmd2.Parameters["@address"].Value = addr.Text.ToString();
            cmd2.Parameters["@regdate"].Value = dpicker.Text;
            cmd2.Parameters["@image"].Value = imageData;
            cmd2.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Patient registered");


        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                path.Text = filename;
            }

        }

        private void Capture_Click(object sender, RoutedEventArgs e)
        {
            CaptureImage cam = new CaptureImage();
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = cam.Handle;
            
            
            cam.setTfirstName(fname.Text);
            cam.setTlastName(lname.Text);
            cam.setTpNumber(pnumber.Text);
            cam.setTaddress(addr.Text);

            cam.TopMost = true;

            cam.Show();
        }
    }
}
