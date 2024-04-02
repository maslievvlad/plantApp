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

namespace PlantApp2
{
    /// <summary>
    /// Логика взаимодействия для BegginingPage.xaml
    /// </summary>
    public partial class BegginingPage : Page
    {
        public BegginingPage()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InputPage());
        }
    }
}
