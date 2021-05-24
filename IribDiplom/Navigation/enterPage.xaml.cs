using IribDiplom.Classes;
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
    /// Логика взаимодействия для enterPage.xaml
    /// </summary>
    public partial class enterPage : Page
    {
        public enterPage()
        {
            InitializeComponent();
        }

        private void enterbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userobj = ConnectDB.db.User.FirstOrDefault(x => x.Login == txblogin.Text && x.Password == psw.Password);
                if (userobj == null)
                {
                    MessageBox.Show("Такого пользователя не существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else 
                {
                    switch(userobj.IdRole)
                    {
                      case 1: Frames.frmobj.Navigate(new AdminPage());
                            break;
                      case 2: Frames.frmobj.Navigate(new UserPage());
                            break;

                    }
 
                }
            }
            catch
            {

            }
        }

        private void Registrationbtn_Click(object sender, RoutedEventArgs e)
        {
            Frames.frmobj.Navigate(new RegistrationPage());

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
       
        }
    }
}
