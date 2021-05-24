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
    /// Логика взаимодействия для RentabsPage.xaml
    /// </summary>
    public partial class RentabsPage : Page
    {
        public RentabsPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Класс для обновления данных из бд
        /// </summary>
        IribEntities Db = new IribEntities();
        void Update()
        {
            dgRentabs.ItemsSource = ConnectDB.db.АнализРентабельности.ToList();
        }

        /// <summary>
        /// Вывод данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dgRentabs.ItemsSource = Classes.ConnectDB.db.АнализРентабельности.ToList();
        }
        /// <summary>
        /// Взаимодействия с Кнооками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rantabsaddbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RentabsDeletebtn_Click(object sender, RoutedEventArgs e)
        {
            var currentRentab = dgRentabs.ItemsSource as АнализРентабельности;
            if ( currentRentab != null)
            {
                Db.АнализРентабельности.Remove(currentRentab);
                Db.SaveChanges();
                Update();

            }
        }

        private void RentabChangebtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ConnectDB.db.SaveChanges();
        }

        private void RentabPrintbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Classes.Frames.frmobj.GoBack();
        }
    }
}
