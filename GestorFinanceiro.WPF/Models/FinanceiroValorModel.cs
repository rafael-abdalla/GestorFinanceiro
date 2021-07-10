using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestorFinanceiro.WPF.Models
{
    public class FinanceiroValorModel
    {
        public string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "n2")]
        public decimal PrecoCusto { get; set; }

        [DisplayFormat(DataFormatString = "n2")]
        public decimal TotalDesconto { get; set; }

        [DisplayFormat(DataFormatString = "n2")]
        public decimal Quantidade { get; set; }

        [DisplayFormat(DataFormatString = "n2")]
        public decimal TotalLiquido => (PrecoCusto * Quantidade) - TotalDesconto;
    }
}
