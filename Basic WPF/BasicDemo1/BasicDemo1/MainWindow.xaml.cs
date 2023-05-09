using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace BasicDemo1
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

        private string? userName;
        private string? password;

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is an informative message.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((!userName?.ToLower().Equals("admin") ?? true) || (!password?.ToLower().Equals("admin") ?? true))
            {
                MessageBox.Show("Incorrect Username or Password", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Login success", "Login", MessageBoxButton.OKCancel, MessageBoxImage.None);
            }
        }

        private void txt_Usename_TextChanged(object sender, TextChangedEventArgs e)
        {
            userName = txt_Username.Text;
        }

        private void txt_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = txt_Password.Text;
        }
    }
}
