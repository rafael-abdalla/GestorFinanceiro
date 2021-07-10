namespace GestorFinanceiro.WPF.ViewModels
{
    public class MensagemViewModel : BaseViewModel
    {
        private string _mensagem;
        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            set
            {
                _mensagem = value;
                OnPropertyChanged(nameof(Mensagem));
                OnPropertyChanged(nameof(TemMensagem));
            }
        }

        public bool TemMensagem => !string.IsNullOrEmpty(Mensagem);
    }
}
