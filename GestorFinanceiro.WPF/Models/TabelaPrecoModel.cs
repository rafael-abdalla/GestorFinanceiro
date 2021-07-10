using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestorFinanceiro.WPF.Models
{
    public class TabelaPrecoModel
    {
        public Guid? Id { get; set; }
        public string Descricao { get; set; }
        [DisplayFormat(DataFormatString = "n2")]
        public decimal Preco { get; set; }
    }
}
