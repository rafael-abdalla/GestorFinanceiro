using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Commands
{
    public abstract class BaseAsyncCommand : ICommand
    {
        private bool _executando;
        public bool Executando
        {
            get { return _executando; }
            set
            {
                _executando = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !Executando;
        }

        public async void Execute(object parameter)
        {
            Executando = true;

            await ExecuteAsync(parameter);

            Executando = false;
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
