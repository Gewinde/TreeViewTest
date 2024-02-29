using System.Collections.ObjectModel;

namespace TreeViewTest.Models
{
    public enum PositionName { Beginner, Advanced, Specalist}
    internal class Position : BaseViewModel
    {
        private PositionName _positionName;
        private ObservableCollection<Employee> _employees = new ObservableCollection<Employee>();

        public Position(PositionName x)
        {
            PositionName = x;
            Employees.Add(new Employee("Mike"));
            Employees.Add(new Employee("Fred"));
            Employees.Add(new Employee("Denny"));
        }
        public PositionName PositionName
        {
            get => _positionName;
            set
            {
                _positionName = value;
                RaisePropertyChanged(nameof(PositionName));
            }
        }

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set
            {
                _employees = value;
                RaisePropertyChanged(nameof(Employees));
            }
        }
    }
}
