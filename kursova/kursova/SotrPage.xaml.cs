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
    /// Логика взаимодействия для SotrPage.xaml
    /// </summary>
    public partial class SotrPage : Page
    {
        public SotrPage()
        {
            InitializeComponent();
            GridSotr.ItemsSource = DBClass.modelEnt.Employees.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.Navigate(new AddSotrPage());
        }
    }
}
