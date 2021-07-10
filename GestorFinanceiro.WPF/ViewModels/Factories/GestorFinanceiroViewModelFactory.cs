using GestorFinanceiro.WPF.State.Navigators;
using System;

namespace GestorFinanceiro.WPF.ViewModels.Factories
{
    public class GestorFinanceiroViewModelFactory : IGestorFinanceiroViewModelFactory
    {
        private readonly CriarViewModel<LoginViewModel> _loginViewModelFactory;
        private readonly CriarViewModel<VendasViewModel> _vendasViewModelFactory;
        private readonly CriarViewModel<TabelaPrecosViewModel> _tabelaPrecoViewModelFactory;
        private readonly CriarViewModel<FinanceiroViewModel> _financeiroViewModelFactory;
        private readonly CriarViewModel<ClienteViewModel> _clienteViewModelFactory;

        public GestorFinanceiroViewModelFactory(
            CriarViewModel<LoginViewModel> loginViewModelFactory,
            CriarViewModel<VendasViewModel> vendasViewModelFactory,
            CriarViewModel<TabelaPrecosViewModel> tabelaPrecoViewModelFactory,
            CriarViewModel<FinanceiroViewModel> financeiroViewModelFactory,
            CriarViewModel<ClienteViewModel> clienteViewModelFactory
        )
        {
            _loginViewModelFactory = loginViewModelFactory;
            _vendasViewModelFactory = vendasViewModelFactory;
            _tabelaPrecoViewModelFactory = tabelaPrecoViewModelFactory;
            _financeiroViewModelFactory = financeiroViewModelFactory;
            _clienteViewModelFactory = clienteViewModelFactory;
        }

        public BaseViewModel CriarViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _loginViewModelFactory();
                case ViewType.Vendas:
                    return _vendasViewModelFactory();
                case ViewType.TabelaPreco:
                    return _tabelaPrecoViewModelFactory();
                case ViewType.Clientes:
                    return _clienteViewModelFactory();
                case ViewType.Financeiro:
                    return _financeiroViewModelFactory();
                default:
                    throw new ArgumentException("Problemas ao encontrar ViewModel.", "ViewModel");
            }
        }
    }
}
