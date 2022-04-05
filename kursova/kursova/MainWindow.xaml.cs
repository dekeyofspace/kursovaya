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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBClass.modelEnt = new DataBase.stosrursEntities();
            FrameClass1.frm = Frame;
            FrameClass1.frm.Navigate(new HomePage());
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
          
        }
    }
}
