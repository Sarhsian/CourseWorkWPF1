using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        ObservableCollection<Person> users = new ObservableCollection<Person>();
        int selected = 0;
        public AdminMenu()
        {
            InitializeComponent();
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Persons.ShopClients)
            {
                users.Add(item);
            }
            DataGrid1.ItemsSource = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name1.Text != null && Surname1.Text != null && Login1.Text != null && Passwod1.Text != null)
            {
                Person user = new Person() { Name = Name1.Text, Login = Login1.Text, Surname = Surname1.Text, Password=Passwod1.Text  };
                Persons.ShopClients.Add(user);
                MessageBox.Show("Succesfull added");
                users.Add(user);
                Name1.Text = "";
                Surname1.Text = "";
                Login1.Text = "";
                Passwod1.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Persons.ShopClients.RemoveAt(DataGrid1.SelectedIndex);
                users.RemoveAt(DataGrid1.SelectedIndex);
                DataGrid1.ItemsSource = users;
                MessageBox.Show("Succesfull");
                
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
