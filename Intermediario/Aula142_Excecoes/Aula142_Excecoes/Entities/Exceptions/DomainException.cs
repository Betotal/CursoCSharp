using System;

namespace Aula142_Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem): base(mensagem)
        {

        }
            
    }
}
