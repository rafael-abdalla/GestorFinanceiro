using GestorFinanceiro.WPF.Models;

namespace GestorFinanceiro.WPF.ViewModels
{
    public delegate TViewModel CriarViewModel<TViewModel>() where TViewModel : BaseViewModel;

    public class BaseViewModel : ObservableObject
    {
    }
}
