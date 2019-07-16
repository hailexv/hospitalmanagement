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

namespace Pizzaria1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class PharmacistWindow : Window
    {
        public PharmacistWindow()
        {
            InitializeComponent();
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new DrugRequests());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

           

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DrugRequests());
                    //descriptiveTitle.Content = "Add patient to a database";
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DrugRequests());
                    //descriptiveTitle.Content = "Transfer patient to a doctor";
                    break;

                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DrugRequests());
                    //descriptiveTitle.Content = "Transfer patient to a doctor";
                    break;

            }
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
            
        }
        /*
private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
   int index = ListViewMenu.SelectedIndex;
   MoveCursorMenu(index);

   switch (index)
   {
       case 0:
           GridPrincipal.Children.Clear();
           GridPrincipal.Children.Add(new UserControlInicio());
           //descriptiveTitle.Content = "Add patient to a database";
           break;
       case 1:
           GridPrincipal.Children.Clear();
           GridPrincipal.Children.Add(new UserControlEscolha());
           //descriptiveTitle.Content = "Transfer patient to a doctor";
           break;
       case 2:
           GridPrincipal.Children.Clear();
           GridPrincipal.Children.Add(new test());
           break;
       default:
           break;
   }
}



private void MoveCursorMenu(int index)
{
   TrainsitionigContentSlide.OnApplyTemplate();
   GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
}

*/
    }
}
