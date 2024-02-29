using System.Collections.ObjectModel;
using TreeViewTest.Models;

namespace TreeViewTest.ViewModels
{
    internal class TreeViewViewModel : BaseViewModel
    {
        private ObservableCollection<Department> _departments = new ObservableCollection<Department>();

        public TreeViewViewModel()
        {
            Departments.Add(new Department(DepartmentName.IT));
            Departments.Add(new Department(DepartmentName.FrontDesk));
            Departments.Add(new Department(DepartmentName.CustomerService));
        }

        public ObservableCollection<Department> Departments
        {
            get => _departments;
            set
            {
                _departments = value;
                RaisePropertyChanged(nameof(Departments));
            }
        }
    }
}
