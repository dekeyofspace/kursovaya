using kursova.DataBase;
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

namespace kursova
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage(Employees employees)
        {
            InitializeComponent();
            FrameClass1.frameproduct = Frameproduct;
            switch (employees.Role.NameRole)
            {
                case "Администратор":

                    break;
                case "Менеджер":
                    Sotr.Visibility = Visibility.Collapsed;
                    Usl.Visibility = Visibility.Collapsed;
                    break;
                case "Бровист":
                    Sotr.Visibility = Visibility.Collapsed;
                    Usl.Visibility = Visibility.Collapsed;
                    Tov.Visibility = Visibility.Collapsed;
                    break;
                case "Парикмахер":
                    Sotr.Visibility = Visibility.Collapsed;
                    Usl.Visibility = Visibility.Collapsed;
                    Tov.Visibility = Visibility.Collapsed;
                    break;
                case "Мастер по маникюру":
                    Sotr.Visibility = Visibility.Collapsed;
                    Usl.Visibility = Visibility.Collapsed;
                    Tov.Visibility = Visibility.Collapsed;
                    break;
                case "Мастер по педикюру":
                    Sotr.Visibility = Visibility.Collapsed;
                    Usl.Visibility = Visibility.Collapsed;
                    Tov.Visibility = Visibility.Collapsed;
                    break;
                default: 
                    break;
            }
        }

        private void Usl_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frameproduct.Navigate(new UslugiPage());
        }

        private void Sotr_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frameproduct.Navigate(new SotrPage());
        }

        private void Tov_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frameproduct.Navigate(new TovPage());
        }

        private void CLi_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frameproduct.Navigate(new ClientPage());
        }

        private void Zap_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frameproduct.Navigate(new ZapisiPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.Navigate(new HomePage());
        }
    }
}
