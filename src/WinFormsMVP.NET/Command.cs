using System.Windows.Input;

namespace WinFormsMVP.NET;

public abstract class Command : ICommand
{
    public event EventHandler CanExecuteChanged;

    private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    public virtual bool CanExecute(object parameter) => true;

    public abstract void Execute(object parameter);
}

public abstract class Command<T> : ICommand where T : IView
{
    protected T View { get; set; }

    protected Command(T view) => View = view;

    public event EventHandler CanExecuteChanged;

    private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    public virtual bool CanExecute(object parameter) => true;

    public abstract void Execute(object parameter);
}