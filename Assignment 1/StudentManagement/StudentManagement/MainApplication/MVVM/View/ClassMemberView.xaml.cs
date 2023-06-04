using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class ClassMemberView : UserControl
    {
        private static readonly ClassMemberService _classMemberService = new();

        public static readonly DependencyProperty RoleProperty =
        DependencyProperty.Register("Role", typeof(string), typeof(ClassMemberView), new PropertyMetadata(null, OnRolePropertyChanged));

        public string Role
        {
            get { return (string)GetValue(RoleProperty); }
            set { SetValue(RoleProperty, value); }
        }

        private static void OnRolePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var view = (ClassMemberView)d;
            var newRole = (string)e.NewValue;
            view.LoadData();
        }

        public ClassMemberView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (Role != null && Role.Equals("student"))
            {
                dgClass.ItemsSource = _classMemberService.GetStudentList();
            }
            else if (Role != null && Role.Equals("teacher"))
            {
                dgClass.ItemsSource = _classMemberService.GetTeacherList();
            }
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            String name = txtSearch.Text;
            List<ClassMember> classMembers;
            if (String.IsNullOrEmpty(name))
            {
                classMembers = _classMemberService.GetMemberByRole(Role);
            } else
            {
                classMembers = _classMemberService.GetClassMemberByRoleAndName(Role, name);
            }
            dgClass.ItemsSource = classMembers;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editButton = (Button)sender;

            ClassMember rowData = (ClassMember)editButton.DataContext;
            if (rowData.MemberId != null)
            {

                ClassMemberEdit editWindow = new ClassMemberEdit(rowData, "Edit");
                editWindow.Owner = Window.GetWindow(this);
                editWindow.Closed += (sender, e) =>
                {
                    dgClass.ItemsSource = _classMemberService.GetMemberByRole(Role);
                };
                editWindow.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClassMember classMember = new ClassMember();
            classMember.Gender = "Male";
            classMember.Role = Role;
            ClassMemberEdit editWindow = new ClassMemberEdit(classMember, "Add");
            editWindow.Owner = Window.GetWindow(this);
            editWindow.Closed += (sender, e) =>
            {
                dgClass.ItemsSource = _classMemberService.GetMemberByRole(Role);
            };
            editWindow.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var editButton = (Button)sender;

            var rowData = (ClassMember)editButton.DataContext;
            var result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                _classMemberService.DeleteMember(rowData.MemberId);
            }
            dgClass.ItemsSource = _classMemberService.GetMemberByRole(Role);
        }
    }
}
