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
    /// Логика взаимодействия для AddZapisPage.xaml
    /// </summary>
    public partial class AddZapisPage : Page
    {
        public AddZapisPage()
        {
            InitializeComponent();
            cmbClient.SelectedValuePath = "id";
            cmbClient.DisplayMemberPath = "FullNameClient";
            cmbClient.ItemsSource = DBClass.modelEnt.Client.ToList();

            cmbUsluga.SelectedValuePath = "id";
            cmbUsluga.DisplayMemberPath = "NameService";
            cmbUsluga.ItemsSource = DBClass.modelEnt.Service.ToList();

            cmbMaster.SelectedValuePath = "id";
            cmbMaster.DisplayMemberPath = "FullNameEmployees";
            cmbMaster.ItemsSource = DBClass.modelEnt.Employees.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProvededService proveded = new ProvededService()
            {
                idService = (int)cmbUsluga.SelectedValue,
                idEmployees = (int)cmbMaster.SelectedValue,
                idClient = (int)cmbClient.SelectedValue,
                Data = date.SelectedDate
            };
            DBClass.modelEnt.ProvededService.Add(proveded);
            DBClass.modelEnt.SaveChanges();
            MessageBox.Show("Запись добавлена");
            FrameClass1.frm.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.GoBack();
        }
    }
}
