using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using DarrenLee.Media;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pizzaria1
{
    public partial class CaptureImage : MaterialForm
    {

        private string TfirstName;
        private string TlastName;
        private string TpNumber;
        private string Taddress;

        int count = 0;
        Camera myCamera = new Camera();

        public CaptureImage()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            
            GetInfo();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
        }

        public void setTfirstName (string s)
        {
            TfirstName = s;
        }
        public void setTlastName(string s)
        {
            TlastName = s;
        }
        public void setTpNumber(string s)
        {
            TpNumber = s;
        }

        public void setTaddress(string s)
        {
            Taddress = s;
        }

        private void GetInfo()
        {
            var cameraDevices = myCamera.GetCameraSources();
            var cameraResolutions = myCamera.GetSupportedResolutions();

            foreach(var d in cameraDevices)
            {
                cmbCameraDevices.Items.Add(d);
            }

            foreach(var r in cameraResolutions)
            {
                cmbCameraResolutions.Items.Add(r);
            }

            cmbCameraResolutions.SelectedIndex = 4;
            cmbCameraDevices.SelectedIndex = 0;
        }

        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image = img;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCameraDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(cmbCameraDevices.SelectedIndex);
        }

        private void cmbCameraResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(cmbCameraResolutions.SelectedIndex);
        }

        private void CaptureImage_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            
            string fileName = Application.StartupPath + @"\" + "image" + count.ToString();
            myCamera.Capture(fileName);
            myCamera.Stop();

            UserControlInicio x = new UserControlInicio();
            x.patientPic.ImageSource = new BitmapImage(
             new Uri(fileName+".jpg"));

            x.fname.Text = TfirstName;
            x.lname.Text = TlastName;

            x.pnumber.Text = TpNumber;
            x.addr.Text = Taddress;
            x.setCapturedPhoto(fileName + ".jpg");

            MainWindow a = new MainWindow();

            


            a.GridPrincipal.Children.Clear();
            a.GridPrincipal.Children.Add(x);
            a.Show();
            this.Close();
            
            //MessageBox.Show(fileName);

            count++;

           // this.Close();
        }
    }
}
