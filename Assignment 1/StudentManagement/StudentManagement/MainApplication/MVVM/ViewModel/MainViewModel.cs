using MainApplication.Core;
using MainApplication.MVVM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private string _role;
        public string Role
        {
            get { return _role; }
            set
            {
                _role = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand ClassMemberViewCommand { get; set; }

        private ClassViewModel _classVM;
        public ClassViewModel ClassVM
        {
            get
            {
                return _classVM;
            }
            set
            {
                _classVM = value;
                OnPropertyChanged();
            }
        }

        public ClassMemberViewModel ClassMemberVM { get; set; }

        private object? _currentView;

        public object? CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.ClassVM = new ClassViewModel();
            this.ClassMemberVM = new ClassMemberViewModel(string.Empty);
            CurrentView = ClassVM;

            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClassVM;
            });
            ClassMemberViewCommand = new RelayCommand(o =>
            {
                Role = o as string;
                CurrentView = ClassMemberVM;
            });
        }

        private void ClassVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Check if the changed property is the Classes property
            if (e.PropertyName == nameof(ClassViewModel.Classes))
            {
                CurrentView = ClassVM;
            }
        }
    }
}
