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

namespace IribDiplom.Navigation
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void RentabCompany_Click(object sender, RoutedEventArgs e)
        {
            Classes.Frames.frmobj.Navigate(new RentabsPage());
        }

        private void DynemicperformBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void еstimationwallbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FacktornyAnalizprocents_Click(object sender, RoutedEventArgs e)
        {
            Classes.Frames.frmobj.Navigate(new ProcRentabsPage());
        }

        private void FacktornyAnaliz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FacktornyAnaliz_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
