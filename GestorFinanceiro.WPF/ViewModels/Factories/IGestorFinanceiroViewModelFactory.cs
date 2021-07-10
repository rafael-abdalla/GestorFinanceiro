using GestorFinanceiro.WPF.State.Navigators;

namespace GestorFinanceiro.WPF.ViewModels.Factories
{
    public interface IGestorFinanceiroViewModelFactory
    {
        BaseViewModel CriarViewModel(ViewType viewType);
    }
}
