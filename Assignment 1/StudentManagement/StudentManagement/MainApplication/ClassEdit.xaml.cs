using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
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
    /// Interaction logic for ClassEdit.xaml
    /// </summary>
    public partial class ClassEdit : Window
    {

        private readonly ClassService _classService = new ClassService();

        private readonly int id;
        private String className;
        private String action;
        public ClassEdit()
        {
            InitializeComponent();
        }

        public ClassEdit(int id, String className, String action)
        {
            InitializeComponent();
            this.id = id;
            this.className = className;
            txtClassId.Text = id.ToString();
            txtClassName.Text = className;
            this.action = action;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window_Closed(sender, e);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (action.Equals("Edit"))
            {
                String className = txtClassName.Text;

                Class input = new Class();
                input.ClassId = id;
                input.ClassName = className;
                (bool, string) result = _classService.UpdateClass(input);
                if (result.Item1)
                {
                    Window_Closed(sender, e);
                }
                else
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButton.OKCancel);
                }
            }
            else if (action.Equals("Add"))
            {
                String className = txtClassName.Text;
                bool isExist = _classService.ExistByClassName(className);
                if (isExist)
                {
                    MessageBox.Show("Class name is exist or null.","Error");
                } else
                {
                    Class input = new Class();
                    input.ClassId = id;
                    input.ClassName = className;
                    _classService.AddNew(input);
                    Window_Closed(sender, e);
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
