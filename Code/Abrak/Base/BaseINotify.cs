using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Abrak.Base
{
    public abstract class BaseINotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
