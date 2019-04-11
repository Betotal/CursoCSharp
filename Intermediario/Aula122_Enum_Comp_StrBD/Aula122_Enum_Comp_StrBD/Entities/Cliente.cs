using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_Enum_Comp_StrBD.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime aniversario)
        {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }
        // programa do professor
        public override string ToString()
        {
            return Nome 
                 + ", ("
                 + Aniversario.ToString("dd/MM/YY") 
                 + ") - " 
                 + Email;
        }
    }
}
