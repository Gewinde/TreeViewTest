using System.Collections.ObjectModel;

namespace TreeViewTest.Models
{
    public enum DepartmentName { IT, FrontDesk, CustomerService}
    internal class Department : BaseViewModel
    {
        private DepartmentName _departmentName;
        private ObservableCollection<Position> _positions = new ObservableCollection<Position>();

        public Department(DepartmentName x)
        {
            _departmentName = x;
            Positions.Add(new Position(PositionName.Beginner));
            Positions.Add(new Position(PositionName.Advanced));
            Positions.Add(new Position(PositionName.Specalist));
        }

        public  DepartmentName DepartmentName
        {
            get => _departmentName;
            set
            {
                _departmentName = value;
                RaisePropertyChanged(nameof(DepartmentName));
            }
        }

        public ObservableCollection<Position> Positions
        {
            get => _positions;
            set
            {
                _positions = value;
                RaisePropertyChanged(nameof(Positions));
            }
        }
    }
}
