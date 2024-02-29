
namespace TreeViewTest.Models
{
    internal class Employee : BaseViewModel
    {
        private string _employeeName;

        public Employee(string x)
        {
            EmployeeName = x;
        }

        public string EmployeeName
        {
            get => _employeeName;
            set
            {
                _employeeName = value;
                RaisePropertyChanged(nameof(EmployeeName));
            }
        }
    }
}
