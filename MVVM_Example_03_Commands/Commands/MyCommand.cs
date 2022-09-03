using System;
using System.Windows.Input;

namespace MVVM_Example_04_Commands.Commands
{
    public class MyCommand : ICommand
    {
        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;

        public MyCommand(Action targetExecuteMethod)
        {
            _TargetExecuteMethod = targetExecuteMethod;
        }
        public MyCommand(Action targetExecuteMethod, Func<bool> targetCanExecuteMethod)
        {
            _TargetExecuteMethod = targetExecuteMethod;
            _TargetCanExecuteMethod = targetCanExecuteMethod;
        }


        public event EventHandler? CanExecuteChanged = delegate{};
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged (this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object? parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }
            return false;
        }

        void ICommand.Execute(object? parameter) 
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }






    }
}
