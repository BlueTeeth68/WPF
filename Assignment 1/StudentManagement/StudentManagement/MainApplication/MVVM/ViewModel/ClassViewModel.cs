using BusinessObject;
using DataAccess;
using MainApplication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.MVVM.ViewModel
{
    internal class ClassViewModel: ObservableObject
    {

        private readonly ClassService _classService = new ClassService();

        private List<Class> _classes;
        public List<Class> Classes
        {
            get { return _classes; }
            set
            {
                _classes = value;
                OnPropertyChanged();
            }
        }

        public ClassViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
             _classes = _classService.GetAll();
        }

    }
}
