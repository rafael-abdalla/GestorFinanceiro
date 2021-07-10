using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.WPF.Commands;
using GestorFinanceiro.WPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class VendasViewModel : BaseViewModel
    {
        ITabelaPrecoService _tabelaPrecoService;

        public ICommand ProcurarTabelaPrecoCommand { get; set; }

        private ObservableCollection<ProdutoViewModel> _produtos;
        public VendasViewModel(ITabelaPrecoService tabelaPrecoService)
        {
            _produtos = new ObservableCollection<ProdutoViewModel>();
            _tabelaPrecoService = tabelaPrecoService;
            ProcurarTabelaPrecoCommand = new ProcurarProdutoCommand(this, _tabelaPrecoService);
        }

        private string _nomeCliente;
        public string NomeCliente
        {
            get
            {
                return _nomeCliente;
            }
            set
            {
                _nomeCliente = value;
                OnPropertyChanged(nameof(NomeCliente));
            }
        }

        private string _nomeProduto;
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                _nomeProduto = value;
                OnPropertyChanged(nameof(NomeProduto));
            }
        }

        public void AdicionarProduto(ProdutoViewModel item)
        {
            var produto = _produtos.Where(x => x.Id == item.Id).FirstOrDefault();

            if (produto == null)
            {
                item.AlteracaoTotal += AcionarSomaProdutos;
                _produtos.Add(item);
            }
            else
            {
                produto.AdicionarQuantidade();
            }

            OnPropertyChanged(nameof(Produtos));
            OnPropertyChanged(nameof(TotalProdutos));
        }

        private void AcionarSomaProdutos()
        {
            OnPropertyChanged(nameof(TotalProdutos));
        }

        public ObservableCollection<ProdutoViewModel> Produtos
        {
            get { return _produtos; }
            set { _produtos = value; }
        }

        public decimal TotalProdutos => _produtos.Sum(x => x.ValorTotal);
    }
}
