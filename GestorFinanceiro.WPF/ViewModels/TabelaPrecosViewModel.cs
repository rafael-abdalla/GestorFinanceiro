using GestorFinanceiro.Domain;
using GestorFinanceiro.Domain.Interfaces;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.WPF.Commands;
using GestorFinanceiro.WPF.Models;
using GestorFinanceiro.WPF.State.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class TabelaPrecosViewModel : BaseViewModel
    {
        private List<TabelaPrecoModel> _tabelas;

        public ITabelaPrecoService _service;
        public ICommand InserirTabelaPrecoCommand { get; set; }

        public TabelaPrecosViewModel(IUnityOfWork uow, ITabelaPrecoService tabelaPrecoService, IAutenticacaoStore accountStore)
        {
            _service = tabelaPrecoService;
            TabelasPrecos = CarregarTabelaPreco();
            InserirTabelaPrecoCommand = new InserirTabelaPrecoCommand(uow, this, tabelaPrecoService, accountStore);
        }

        private List<TabelaPrecoModel> CarregarTabelaPreco()
        {
            var resultado = _service.ObterTodos();
            var tabelas = new List<TabelaPrecoModel>();
            foreach (var tabela in resultado)
            {
                tabelas.Add(new TabelaPrecoModel() { Id = tabela.Id, Descricao = tabela.Descricao, Preco = tabela.Preco });
            }
            return tabelas;
        }

        public List<TabelaPrecoModel> TabelasPrecos
        {
            get
            {
                return _tabelas;
            }
            set
            {
                _tabelas = value;
                OnPropertyChanged(nameof(TabelasPrecos));
            }
        }

    }
}
