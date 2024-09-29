﻿using System;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if(Name.ToString() == "" || Password.ToString() == "")
                MessageBox.Show("Неверный логин или пароль!");
            if (Name.ToString() != "" && Password.ToString() != "")
            {
                MessageBox.Show("Регистрация успешно пройдена!");
                this.Close();
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
