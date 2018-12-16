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
    /// Interaction logic for StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
        }

        private void Admbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenuWindow = new AdminMenu();
            adminMenuWindow.ShowDialog();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello how are you?");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.ShowDialog();
        }
    }
}
