using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreeViewTest.Services
{
    internal class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string PropertyName = "")
        {
            if (!String.IsNullOrEmpty(PropertyName))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
