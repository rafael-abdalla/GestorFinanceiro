using System;
using System.Runtime.Serialization;

namespace GestorFinanceiro.Domain.Exceptions
{
    public class SenhaInvalidaException : Exception
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public SenhaInvalidaException(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public SenhaInvalidaException(string message, string login, string senha) : base(message)
        {
            Login = login;
            Senha = senha;
        }

        public SenhaInvalidaException(string message, Exception innerException, string login, string senha) : base(message, innerException)
        {
            Login = login;
            Senha = senha;
        }

        protected SenhaInvalidaException(SerializationInfo info, StreamingContext context, string login, string senha) : base(info, context)
        {
            Login = login;
            Senha = senha;
        }
    }
}
