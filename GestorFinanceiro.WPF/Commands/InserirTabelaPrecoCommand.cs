using GestorFinanceiro.Domain;
using GestorFinanceiro.Domain.Interfaces;
using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.WPF.State.Accounts;
using GestorFinanceiro.WPF.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Commands
{
    public class InserirTabelaPrecoCommand : ICommand
    {
        private readonly IUnityOfWork _uow;
        private TabelaPrecosViewModel _viewModel;
        private ITabelaPrecoService _tabelaPrecoService;
        private readonly IAutenticacaoStore _accountStore;

        public event EventHandler CanExecuteChanged;

        public InserirTabelaPrecoCommand(IUnityOfWork uow, TabelaPrecosViewModel viewModel, ITabelaPrecoService tabelaPrecoService, IAutenticacaoStore accountStore)
        {
            _uow = uow;
            _viewModel = viewModel;
            _tabelaPrecoService = tabelaPrecoService;
            _accountStore = accountStore;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                foreach(var tabela in _viewModel.TabelasPrecos)
                {
                   if(tabela.Id == null)
                    {
                        var lancamento = new Lancamento(Guid.NewGuid(), _accountStore.LoginCache.Id, DateTime.Now);
                        var tabelaPreco = new TabelaPreco(Guid.NewGuid(), tabela.Descricao.ToUpper(), tabela.Preco, lancamento.Id);
                        tabelaPreco.Lancamento = lancamento;
                        _tabelaPrecoService.Inserir(tabelaPreco);

                        _uow.Commit();
                        tabela.Id = tabelaPreco.Id;
                    }
                }

            }
            catch (Exception e)
            {
                _uow.Rollback();
                MessageBox.Show(e.Message);
            }
        }
    }
}
