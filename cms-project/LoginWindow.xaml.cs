using System;
using System.Collections.Generic;
using System.IO;
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
        string path = "D:\\github\\cms-project\\database.txt";
        private void btnLogin_click(object sender, RoutedEventArgs e)
        {
            string login = AdminName.Text;
            string password = AdminPassword.Password;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                bool isAuthenticated = false; // Флаг для отслеживания успешной аутентификации

                while ((line = reader.ReadLine()) != null)
                {
                    // Предположим, что логин и пароль разделены двоеточием
                    string[] parts = line.Split(':'); // Разделяем строку на логин и пароль

                    if (parts.Length == 2) // Убедимся, что у нас есть и логин, и пароль
                    {
                        string fileLogin = parts[0].Trim(); // Логин из файла
                        string filePassword = parts[1].Trim(); // Пароль из файла

                        if (fileLogin == login && filePassword == password) // Сравниваем с введенными данными
                        {
                            isAuthenticated = true; // Успешная аутентификация
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show(); // Показываем главное окно
                            break; // Выходим из цикла, так как аутентификация успешна
                        }
                    }
                }

                if (!isAuthenticated) // Если не было успешной аутентификации
                {
                    MessageBox.Show("Неверный пароль");
                }
            }

        }
    }
}
