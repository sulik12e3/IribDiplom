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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, RoutedEventArgs e)
        {
            if(ConnectDB.db.User.Count(x=> x.Login == txblogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                User userobj = new User()
                {
                    Login = txblogin.Text,
                    Password = psw.Password,
                    IdRole = 1

                };
                ConnectDB.db.User.Add(userobj);
                ConnectDB.db.SaveChanges();
                MessageBox.Show("Аккаунт создан", "Уведомлние", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void psw1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (psw.Password == psw1.Password)
            {
                createbtn.IsEnabled = true;
                psw1.Background = Brushes.LightGreen;
                psw1.BorderBrush = Brushes.Green;
            }
            else
            {
                createbtn.IsEnabled = false;
                psw1.Background = Brushes.LightCoral;
                psw1.BorderBrush = Brushes.Red;
            }
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frames.frmobj.GoBack();
        }
    }
}
