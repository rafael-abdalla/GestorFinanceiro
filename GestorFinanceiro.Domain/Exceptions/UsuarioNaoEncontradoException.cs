using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GestorFinanceiro.Domain.Exceptions
{
    public class UsuarioNaoEncontradoException : Exception
    {
        public string Login { get; set; }

        public UsuarioNaoEncontradoException(string login)
        {
            Login = login;
        }

        public UsuarioNaoEncontradoException(string message, string login) : base(message)
        {
            Login = login;
        }

        public UsuarioNaoEncontradoException(string message, Exception innerException, string login) : base(message, innerException)
        {
            Login = login;
        }

    }
}
