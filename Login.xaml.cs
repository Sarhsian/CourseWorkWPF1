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

namespace CourseWorkWPF1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        StoreWindow storeWindow = new StoreWindow();
        Signup SignupWindow = new Signup();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            SignupWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Login1.Text == "User" && PasswordBox1.Password == "User")
            {
                this.Close();
                storeWindow.Admbtn.Visibility = System.Windows.Visibility.Hidden;
                storeWindow.ShowDialog();
            }
            else if (Login1.Text == "Admin" && PasswordBox1.Password == "Admin")
            {
                this.Close();
                storeWindow.ShowDialog();
            }
            else
            {
                foreach (var client in SignupWindow.ShopClients)
                {
                    if(Login1.Text == client.Login && PasswordBox1.Password.ToString() == client.Password)
                    {
                        storeWindow.ShowDialog();
                    }
                }
            }

        }
    }
}
