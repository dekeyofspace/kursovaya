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
    /// Логика взаимодействия для AddTovPage.xaml
    /// </summary>
    public partial class AddTovPage : Page
    {
        public AddTovPage()
        {
            InitializeComponent();
            cmbCate.SelectedValuePath = "id";
            cmbCate.DisplayMemberPath = "NameGategory";
            cmbCate.ItemsSource = DBClass.modelEnt.Gategory.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                idCategory = (int)cmbCate.SelectedValue,
                NameProduct = txbTov.Text,
                Quantity = int.Parse(txbKol.Text)
            };
            DBClass.modelEnt.Product.Add(product);
            DBClass.modelEnt.SaveChanges();
            MessageBox.Show("Товар заказан");
            FrameClass1.frm.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.GoBack();
        }
    }
}
