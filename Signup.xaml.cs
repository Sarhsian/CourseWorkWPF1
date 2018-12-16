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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Window
    {
        public List<Person> ShopClients = new List<Person>();
        public Person tempPerson = new Person();
        public Signup()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            tempPerson.Name = tbxName.Text;
            tempPerson.Surname = tbxSurname.Text;
            tempPerson.Login = tbxLogin.Text;
            tempPerson.Password = tbxPassword.Text;
            Persons.ShopClients.Add(tempPerson);
            
            tempPerson = new Person();
            this.Visibility = System.Windows.Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
