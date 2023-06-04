using DataAccess;
using BusinessObject;
using DataAccess.Repository.Impl;
using System;
using System.Windows;
using System.Drawing;
using System.Windows.Media;

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly UserService _userService;
        public MainWindow()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            String username = txtUsername.Text?.Trim();
            txtUsername.Text = username;
            String password = txtPassword?.Password?.ToString();
            (bool, string) result = _userService.existsByUsernameAndPassword(username, password);
            if (result.Item1)
            {
                User user = _userService.GetUserByUsername(username);
                Home homeWindow = new Home(user.FullName);
                homeWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Item2, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if (e.Key == System.Windows.Input.Key.Escape)
            {
                btnClose_Click(sender, e);
            }
            return;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        
    }
}
