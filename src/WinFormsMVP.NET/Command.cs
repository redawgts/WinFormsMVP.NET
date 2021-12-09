using System;
using System.Windows.Input;

namespace WinFormsMVP.NET
{
    public abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;

        public abstract void Execute(object parameter);
    }

    public abstract class Command<T> : ICommand where T : IView
    {
        protected Command(T view)
        {
            View = view;
        }

        protected T View { get; }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;

        public abstract void Execute(object parameter);
    }
}