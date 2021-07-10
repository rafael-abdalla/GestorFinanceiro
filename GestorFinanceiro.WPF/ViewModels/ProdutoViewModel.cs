using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class ProdutoViewModel : BaseViewModel
    {
        public delegate void AlteracaoTotalEvent();
        public event AlteracaoTotalEvent AlteracaoTotal;

        public ProdutoViewModel(Guid id, string nomeProduto, decimal quantidade, decimal preco)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Guid Id { get; set; }
        public string NomeProduto { get; set; }

        private decimal _quantidade;

        [DisplayFormat(DataFormatString = "0.###")]
        public decimal Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
                AlteracaoTotal?.Invoke();
                OnPropertyChanged(nameof(Quantidade));
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public decimal Preco { get; set; }

        private decimal _totalDesconto;

        [DisplayFormat(DataFormatString = "n2")]
        public decimal TotalDesconto
        {
            get
            {
                return _totalDesconto;
            }
            set
            {
                _totalDesconto = value;
                AlteracaoTotal?.Invoke();
                OnPropertyChanged(nameof(TotalDesconto));
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        [DisplayFormat(DataFormatString = "n2")]
        public decimal ValorTotal => (Quantidade * Preco) - TotalDesconto;

        public void AdicionarQuantidade()
        {
            Quantidade += 1;
        }
    }
}
