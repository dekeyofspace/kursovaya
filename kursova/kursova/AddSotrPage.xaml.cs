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
    /// Логика взаимодействия для AddSotrPage.xaml
    /// </summary>
    public partial class AddSotrPage : Page
    {
        public AddSotrPage()
        {
            InitializeComponent();
            cmbCat.SelectedValuePath = "id";
            cmbCat.DisplayMemberPath = "NameRole";
            cmbCat.ItemsSource = DBClass.modelEnt.Role.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employees employees = new Employees()
            {
                Login = txbLogin.Text,
                Password = psbPassword.Password,
                FullNameEmployees = txbName.Text,
                idRole = (int)cmbCat.SelectedValue
            };
            DBClass.modelEnt.Employees.Add(employees);
            DBClass.modelEnt.SaveChanges();
            MessageBox.Show("Сотрудник зарегистрирован!");
            FrameClass1.frm.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass1.frm.GoBack();
        }
    }
}
