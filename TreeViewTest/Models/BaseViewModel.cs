using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreeViewTest.Models
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string PropertyName = "")
        {
            if (!string.IsNullOrEmpty(PropertyName))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
