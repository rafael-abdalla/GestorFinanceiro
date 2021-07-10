using GestorFinanceiro.WPF.Models;
using System.Collections.Generic;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class ProcuraViewModel : BaseViewModel
    {
        private string _textoProcura;
        public string TextoProcura
        {
            get
            {
                return _textoProcura;
            }
            set
            {
                _textoProcura = value;
                OnPropertyChanged(nameof(TextoProcura));
            }
        }


        private List<ProcuraModel> _resultados;
        public List<ProcuraModel> Resultados
        {
            get
            {
                return _resultados;
            }
            set
            {
                _resultados = value;
            }
        }

        private dynamic _selecao;
        public dynamic Selecao
        {
            get
            {
                return _selecao;
            }
            set
            {
                _selecao = value;
            }
        }
    }
}
