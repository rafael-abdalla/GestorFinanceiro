using GestorFinanceiro.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class FinanceiroViewModel : BaseViewModel
    {

        public FinanceiroViewModel()
        {
            var data = DateTime.Now;
            _dataInicial = new DateTime(data.Year, data.Month, 1);
            _dataFinal = data;
            _financeiroValores = new ObservableCollection<FinanceiroValorModel>();
        }

        private DateTime _dataInicial;

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataInicial
        {
            get
            {
                return _dataInicial;
            }
            set
            {
                _dataInicial = value;
                OnPropertyChanged(nameof(DataInicial));
            }
        }

        private DateTime _dataFinal;

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataFinal
        {
            get
            {
                return _dataFinal;
            }
            set
            {
                _dataFinal = value;
                OnPropertyChanged(nameof(DataInicial));
            }
        }

        private ObservableCollection<FinanceiroValorModel> _financeiroValores;
        public ObservableCollection<FinanceiroValorModel> FinanceiroValores
        {
            get
            {
                return _financeiroValores;
            }
            set
            {
                _financeiroValores = value;
                OnPropertyChanged(nameof(FinanceiroValores));
            }
        }

        public decimal ValorTotal => FinanceiroValores.Sum(x => x.TotalLiquido);
    }
}
