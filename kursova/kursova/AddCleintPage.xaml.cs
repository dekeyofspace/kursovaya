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
    /// Логика взаимодействия для AddCleintPage.xaml
    /// </summary>
    public partial class AddCleintPage : Page
    {
        public AddCleintPage()
        {
            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client()
            {
                FullNameClient = txbName.Text,
                NumberPhone = long.Parse(txbProne.Text)
            };
            DBClass.modelEnt.Client.Add(client);
            DBClass.modelEnt.SaveChanges();
            MessageBox.Show("Клиент добавлен");
            FrameClass1.frm.GoBack();
        }
    }
}
