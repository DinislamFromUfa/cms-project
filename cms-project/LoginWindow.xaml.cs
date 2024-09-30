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
using System.Windows.Shapes;

namespace cms_project
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_click(object sender, RoutedEventArgs e)
        {
            string login = AdminName.Text;
            string password = AdminPassword.Password;

            if (login == "Admin" &&  password == "Admin")
            {
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
