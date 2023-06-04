using BusinessObject;
using DataAccess;
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

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for ClassMemberEdit.xaml
    /// </summary>
    public partial class ClassMemberEdit : Window
    {

        private String action;
        private ClassMember classMember;
        private readonly ClassMemberService _classMemberService = new ClassMemberService();
        public ClassMemberEdit()
        {
            InitializeComponent();
        }

        public ClassMemberEdit(ClassMember classMember, String action)
        {
            InitializeComponent();
            this.classMember = classMember;
            this.action = action;
            txtMemberId.Text = classMember.MemberId;
            txtFirstName.Text = classMember.FirstName;
            txtLastName.Text = classMember.LastName;
            DOB.SelectedDate = classMember.DateOfBirth;

            cboGender.Loaded += (sender, e) =>
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedGenderItem = comboBox.Items.OfType<ComboBoxItem>()
                    .FirstOrDefault(item => item.Content.ToString() == classMember.Gender);
                comboBox.SelectedItem = selectedGenderItem;
            };

            if (action.Equals("Add"))
            {
                DOB.IsEnabled = true;
                txtMemberId.IsReadOnly = false;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window_Closed(sender, e);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (action.Equals("Edit"))
            {
                classMember.FirstName = txtFirstName.Text;
                classMember.LastName = txtLastName.Text;
                classMember.Gender = cboGender.Text;
                if (String.IsNullOrEmpty(classMember.FirstName))
                {
                    MessageBox.Show("First name can not empty", "Error", MessageBoxButton.OKCancel);
                }
                else if (String.IsNullOrEmpty(classMember.LastName))
                {
                    MessageBox.Show("Last name can not empty", "Error", MessageBoxButton.OKCancel);
                }
                else
                {
                    _classMemberService.UpdateMember(classMember);
                    Window_Closed(sender, e);
                }
            }
            else if (action.Equals("Add"))
            {
                classMember.MemberId = txtMemberId.Text; 
                classMember.FirstName = txtFirstName.Text;
                classMember.LastName = txtLastName.Text;
                classMember.Gender = cboGender.Text;
                classMember.DateOfBirth = DOB.SelectedDate;
                (bool, String) result = _classMemberService.AddNew(classMember);
                if (result.Item1)
                {
                    Window_Closed(sender, e);
                } else
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButton.OKCancel);
                }
            }
        }
    }
}
