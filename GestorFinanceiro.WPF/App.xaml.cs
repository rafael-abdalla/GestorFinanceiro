using GestorFinanceiro.Domain.Interfaces;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.Domain.Services.Autenticacao;
using GestorFinanceiro.EntityFramework.Persistence.Context;
using GestorFinanceiro.EntityFramework.Services;
using GestorFinanceiro.EntityFramework.Transaction;
using GestorFinanceiro.WPF.State.Accounts;
using GestorFinanceiro.WPF.State.Authenticators;
using GestorFinanceiro.WPF.State.Navigators;
using GestorFinanceiro.WPF.ViewModels;
using GestorFinanceiro.WPF.ViewModels.Factories;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace GestorFinanceiro.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<GestorFinanceiroContext>();
                    services.AddScoped<IUnityOfWork, UnityOfWork>();

                    services.AddSingleton<IPasswordHasher, PasswordHasher>();
                    services.AddSingleton<IUsuarioService, UsuarioDataService>();
                    services.AddSingleton<ITabelaPrecoService, TabelaPrecoDataService>();
                    services.AddSingleton<IAutenticacaoService, AutenticacaoService>();

                    services.AddSingleton<IGestorFinanceiroViewModelFactory, GestorFinanceiroViewModelFactory>();

                    services.AddSingleton<ViewModelDelegateRenavigator<VendasViewModel>>();

                    services.AddSingleton<VendasViewModel>();
                    services.AddSingleton<TabelaPrecosViewModel>();
                    services.AddSingleton<FinanceiroViewModel>();
                    services.AddSingleton<ClienteViewModel>();

                    services.AddSingleton<CriarViewModel<LoginViewModel>>(services =>
                    {
                        return () => new LoginViewModel(
                            services.GetRequiredService<IAuthenticator>(),
                            services.GetRequiredService<ViewModelDelegateRenavigator<VendasViewModel>>()
                        );
                    });

                    services.AddSingleton<CriarViewModel<TabelaPrecosViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<TabelaPrecosViewModel>();
                    });

                    services.AddSingleton<CriarViewModel<VendasViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<VendasViewModel>();
                    });

                    services.AddSingleton<CriarViewModel<FinanceiroViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<FinanceiroViewModel>();
                    });

                    services.AddSingleton<CriarViewModel<ClienteViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<ClienteViewModel>();
                    });

                    services.AddSingleton<IRenavigator, ViewModelDelegateRenavigator<VendasViewModel>>();

                    services.AddScoped<INavigator, Navigator>();
                    services.AddScoped<IAuthenticator, Authenticator>();
                    services.AddScoped<IAutenticacaoStore, AutenticacaoStore>();
                    services.AddScoped<MainViewModel>();

                    services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
