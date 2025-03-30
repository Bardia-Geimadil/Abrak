using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Abrak.Base
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        Action<object> _execute;
        Predicate<object> _canExecute;

        public RelayCommand(Action<object> action, Predicate<object>? predicate = null)
        {
            _execute = action;
            _canExecute = predicate;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
