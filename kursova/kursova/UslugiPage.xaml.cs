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
    /// Логика взаимодействия для UslugiPage.xaml
    /// </summary>
    public partial class UslugiPage : Page
    {
        public UslugiPage()
        {
            InitializeComponent();
            cmbSearch1.SelectedValuePath = "id";
            cmbSearch1.DisplayMemberPath = "NameGategory";
            cmbSearch1.ItemsSource = DBClass.modelEnt.Gategory.ToList();
            GridUsl.ItemsSource = DBClass.modelEnt.Service.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridUsl.ItemsSource = DBClass.modelEnt.Service.Where(x => x.idCategory == (int)cmbSearch1.SelectedValue).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.Navigate(new AddUslPage());
        }
    }
}
