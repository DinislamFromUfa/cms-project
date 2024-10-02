using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cms_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void PanelAdministration_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate( new PageAdminPanel());

        }

        private void ContentManagement_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new PageContentManage());
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new PageStatistics());
        }

        private void Mailings_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new PageMailings());
        }
    }
}