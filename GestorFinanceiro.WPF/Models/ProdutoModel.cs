using System;

namespace GestorFinanceiro.WPF.Models
{
    public class ProdutoModel
    {
        public ProdutoModel(Guid id, string nomeProduto, decimal quantidade, decimal preco, decimal totalDesconto)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Preco = preco;
            TotalDesconto = totalDesconto;
        }

        public Guid Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal ValorTotal => (Quantidade * Preco) - TotalDesconto;

        public void AdicionarQuantidade()
        {
            Quantidade += 1;
        }
    }
}
