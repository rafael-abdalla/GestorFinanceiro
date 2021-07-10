using GestorFinanceiro.WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Views.Autenticacao
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public ICommand LoginCommand
        {
            get { return (ICommand)GetValue(LoginCommandProperty); }
            set { SetValue(LoginCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LoginCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoginCommandProperty =
            DependencyProperty.Register("LoginCommand", typeof(ICommand), typeof(ucLogin));

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((LoginViewModel)this.DataContext).Senha = ((PasswordBox)sender).SecurePassword;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(LoginCommand != null)
            {
                string senha = txtSenha.Password;
                LoginCommand.Execute(senha);
            }
        }
    }
}
