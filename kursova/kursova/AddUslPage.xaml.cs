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
    /// Логика взаимодействия для AddUslPage.xaml
    /// </summary>
    public partial class AddUslPage : Page
    {
        public AddUslPage()
        {
            InitializeComponent();
            cmbCateg.SelectedValuePath = "id";
            cmbCateg.DisplayMemberPath = "NameGategory";
            cmbCateg.ItemsSource = DBClass.modelEnt.Gategory.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Service service = new Service()
            {
                NameService = txbUsl.Text,
                price = int.Parse(txbPrice.Text),
                idCategory = (int)cmbCateg.SelectedValue
            };
            DBClass.modelEnt.Service.Add(service);
            DBClass.modelEnt.SaveChanges();
            MessageBox.Show("Услуга добавлена!");
            FrameClass1.frm.GoBack();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.GoBack();
        }
    }
}
