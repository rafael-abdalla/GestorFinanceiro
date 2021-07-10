using Microsoft.AspNet.Identity;
using GestorFinanceiro.Domain.Models;
using System;
using System.Threading.Tasks;
using GestorFinanceiro.Domain.Exceptions;

namespace GestorFinanceiro.Domain.Services.Autenticacao
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IPasswordHasher _passwordHasher;
        public AutenticacaoService(IUsuarioService usuarioService, IPasswordHasher passwordHasher)
        {
            _usuarioService = usuarioService;
            _passwordHasher = passwordHasher;
        }

        public void Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> Login(string login, string senha)
        {
            var usuario = await _usuarioService.ObterPorLogin(login);

            if (usuario == null) throw new UsuarioNaoEncontradoException(login);

            PasswordVerificationResult verificacaoSenha = _passwordHasher.VerifyHashedPassword(usuario.Senha, senha);

            if (verificacaoSenha != PasswordVerificationResult.Success) throw new SenhaInvalidaException(login, senha);

            return usuario;
        }
    }
}
