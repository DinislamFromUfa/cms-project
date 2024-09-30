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
using System.IO;

namespace cms_project
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        string path = "D:\\github\\cms-project\\database.txt";
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if(Name.ToString() == "" || Password.ToString() == "")
                MessageBox.Show("Неверный логин или пароль!");

            if (Name.ToString() != "" && Password.ToString() != "")
            {
                using (StreamWriter writer = new StreamWriter(path, true)) 
                {
                    writer.WriteLine(Name.Text.ToString());
                    writer.WriteLine(Password.Password.ToString());
                    writer.Close();
                }




                    MessageBox.Show("Регистрация успешно пройдена!");
                LoginWindow loginWindow = new LoginWindow();
                if (loginWindow.ShowDialog() == true)
                {
                    this.Show();

                }
                else
                {
                    this.Close();
                }

            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();



            if (loginWindow.ShowDialog() == true)
            {
                this.Show();
                
            }
            else
            {
                this.Close();
            }
        }
    }
}
