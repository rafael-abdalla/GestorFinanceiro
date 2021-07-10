using GestorFinanceiro.WPF.ViewModels;
using System;

namespace GestorFinanceiro.WPF.State.Navigators
{
    public enum ViewType
    {
        Login,
        Vendas,
        TabelaPreco,
        Financeiro,
        Clientes,
        ContasCliente,
        Usuario
    }

    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
