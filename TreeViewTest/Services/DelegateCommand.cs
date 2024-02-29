using System.Windows.Input;

namespace TreeViewTest.Services
{
    internal class DelegateCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public DelegateCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = null;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;
        public void Execute(object parameter) => _execute?.Invoke(parameter);
    }
}
