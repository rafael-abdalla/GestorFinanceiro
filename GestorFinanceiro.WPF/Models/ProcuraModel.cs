using System;

namespace GestorFinanceiro.WPF.Models
{
    public class ProcuraModel
    {
        public ProcuraModel(Guid id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
    }
}
