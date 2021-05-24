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
    /// Логика взаимодействия для ProcRentabsPage.xaml
    /// </summary>
    public partial class ProcRentabsPage : Page
    {
        public ProcRentabsPage()
        {
            InitializeComponent();
        }
        IribEntities DbProc = new IribEntities();
       
        /// <summary>
        /// Взаимодействие с кнопками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ProcRantabsaddbtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ProcRentabsDeletebtn_Click(object sender, RoutedEventArgs e)
        {
            var currentRentabproc = dgprocRentabs.ItemsSource as АнализрентабельностивПроцентах;
            if (currentRentabproc != null)
            {
                DbProc.АнализрентабельностивПроцентах.Remove(currentRentabproc);
                DbProc.SaveChanges();
                dgprocRentabs.ItemsSource = ConnectDB.db.АнализрентабельностивПроцентах.ToList();

            }
        }

        private void ProcRentabChangebtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ConnectDB.db.SaveChanges(); 
        }

        private void ProcRentabPrintbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        /// <summary>
        /// Вывод данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dgprocRentabs.ItemsSource = Classes.ConnectDB.db.АнализрентабельностивПроцентах.ToList();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Frames.frmobj.GoBack();

        }

       
    }
}
