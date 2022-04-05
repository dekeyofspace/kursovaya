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
using kursova.DataBase;

namespace kursova
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public bool check { get; set; }

        private void AutorizeClick_Click(object sender, RoutedEventArgs e)
        {
            var userObj = DBClass.modelEnt.Employees.FirstOrDefault(
                x => x.Login == txbLogA.Text && x.Password == psbPassA.Password);
            if (userObj != null)
            {
                MessageBox.Show("Добро пожаловать!");
                FrameClass1.frm.Navigate(new MenuPage(userObj));
            }
            else
            {
                MessageBox.Show("Такого пользователя нет :(", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }
    }
}
