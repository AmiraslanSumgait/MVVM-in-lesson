using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<Object> _execute { get; set; }
        private Predicate<Object> _canExecute { get; set; }
        public RelayCommand(Action<Object> execute, Predicate<Object> canExecute = null)
        {
            if (execute == null)
            {
                throw new NullReferenceException("Execute null");
            }
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
       
    }
}
