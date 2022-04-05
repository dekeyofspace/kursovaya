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
    /// Логика взаимодействия для TovPage.xaml
    /// </summary>
    public partial class TovPage : Page
    {
        public TovPage()
        {
            InitializeComponent();
            CmbSearchCategory.SelectedValuePath = "id";
            CmbSearchCategory.DisplayMemberPath = "NameGategory";
            CmbSearchCategory.ItemsSource = DBClass.modelEnt.Gategory.ToList();
            GridTov.ItemsSource = DBClass.modelEnt.Product.ToList();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            GridTov.ItemsSource = DBClass.modelEnt.Product.Where(x => x.idCategory == (int)CmbSearchCategory.SelectedValue).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.Navigate(new AddTovPage());
        }
    }
}
