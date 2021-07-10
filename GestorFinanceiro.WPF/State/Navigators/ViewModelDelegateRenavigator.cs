using GestorFinanceiro.WPF.ViewModels;

namespace GestorFinanceiro.WPF.State.Navigators
{
    public class ViewModelDelegateRenavigator<TViewModel> : IRenavigator where TViewModel : BaseViewModel
    {
        private readonly INavigator _navigator;
        private readonly CriarViewModel<TViewModel> _criarViewModel;

        public ViewModelDelegateRenavigator(INavigator navigator, CriarViewModel<TViewModel> criarViewModel)
        {
            _navigator = navigator;
            _criarViewModel = criarViewModel;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _criarViewModel();
        }

    }
}
