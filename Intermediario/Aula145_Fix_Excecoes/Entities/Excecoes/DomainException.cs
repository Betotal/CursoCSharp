using System;


namespace Aula145_Fix_Excecoes.Entities.Excecoes
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {

        }
    }
}
