using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.WPF.Models;
using GestorFinanceiro.WPF.ViewModels;
using GestorFinanceiro.WPF.Views.Controles;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Commands
{
    public class ProcurarProdutoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private VendasViewModel _viewModel;
        private ITabelaPrecoService _tabelaPrecoService;

        public ProcurarProdutoCommand(VendasViewModel viewModel, ITabelaPrecoService tabelaPrecoService)
        {
            _viewModel = viewModel;
            _tabelaPrecoService = tabelaPrecoService;
        }

        public ProcurarProdutoCommand(ITabelaPrecoService tabelaPrecoService)
        {
            _tabelaPrecoService = tabelaPrecoService;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            var viewModel = ((VendasViewModel)parameter);
            var resultado = (List<TabelaPreco>)_tabelaPrecoService.ProcurarPorDescricao(viewModel.NomeProduto);

            if (resultado.Count == 1)
            {
                var prod = resultado.FirstOrDefault();
                _viewModel.AdicionarProduto(new ProdutoViewModel(prod.Id, prod.Descricao, 1, prod.Preco));
                return;
            }

            var procura = new List<ProcuraModel>();
            resultado.ForEach(x => procura.Add(new ProcuraModel(x.Id, x.Descricao)));

            var controle = new ucProcura();
            var procuraViewModel = new ProcuraViewModel();
            procuraViewModel.TextoProcura = viewModel.NomeProduto;
            procuraViewModel.Resultados = procura;
            controle.DataContext = procuraViewModel;
            
            await DialogHost.Show(controle, "RootDialog");
            
            var procuraResultado = ((ProcuraViewModel)controle.DataContext).Selecao;
            if(procuraResultado != null)
            {
                var prod = (TabelaPreco)_tabelaPrecoService.ObterPorId(procuraResultado.Id);
                _viewModel.AdicionarProduto(new ProdutoViewModel(prod.Id, prod.Descricao, 1, prod.Preco));
            }
        }
    }
}
