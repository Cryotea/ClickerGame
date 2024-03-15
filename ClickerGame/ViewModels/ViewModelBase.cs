using System.ComponentModel;
using ReactiveUI;

namespace ClickerGame.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected void RaisePropertyChanged(string propertyName)
    {
        OnPropertyChanged(propertyName);
    }
}