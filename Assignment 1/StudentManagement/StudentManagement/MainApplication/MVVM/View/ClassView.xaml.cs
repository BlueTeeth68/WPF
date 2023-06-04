using BusinessObject;
using DataAccess;
using MainApplication.MVVM.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication.MVVM.View
{
    /// <summary>
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class ClassView : UserControl
    {
        private readonly ClassViewModel _viewModel;
        private readonly ClassService _classService = new();
        public ClassView()
        {
            InitializeComponent();
            _viewModel = new ClassViewModel();
            DataContext = _viewModel;
            _viewModel.LoadData();
            dgClass.ItemsSource = _viewModel.Classes;

        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchValue = txtSearch.Text;
            List<Class> classes;
            if (searchValue == null || searchValue.Trim().Equals(""))
            {
                classes = _classService.GetAll();
            }
            else
            {
                classes = _classService.FindByClassName(searchValue);
            }
            dgClass.ItemsSource = classes;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editButton = (Button)sender;

            var rowData = (Class)editButton.DataContext;
            if (rowData.ClassId != null)
            {
                ClassEdit editWindow = new ClassEdit(rowData.ClassId, rowData.ClassName, "Edit");
                editWindow.Owner = Window.GetWindow(this);
                editWindow.Closed += (sender, e) =>
                {
                    _viewModel.LoadData();
                    dgClass.ItemsSource = _viewModel.Classes;
                };
                editWindow.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            var editButton = (Button)sender;

            var rowData = (Class)editButton.DataContext;
            var result = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                _classService.DeleteClass(rowData.ClassId);
            }
            _viewModel.LoadData();
            dgClass.ItemsSource = _viewModel.Classes;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int maxIdClass = _classService.GetAll().Max(c => c.ClassId);
            int newClassId = maxIdClass + 1;

            ClassEdit editWindow = new ClassEdit(newClassId,"", "Add");
            editWindow.Owner = Window.GetWindow(this);
            editWindow.Closed += (sender, e) =>
            {
                _viewModel.LoadData();
                dgClass.ItemsSource = _viewModel.Classes;
            };
            editWindow.ShowDialog();


        }
    }
}
