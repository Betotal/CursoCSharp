using System;
using System.Collections.Generic;
using System.Text;

namespace Aula130_131_Exercicio.Entities
{
    class Contratado : Funcionario
    {
        public double Adicional { get; set; }

        public Contratado(string nome, int horasTrab, double valHora, double adicional) : base(nome, horasTrab, valHora)
        
        {
            Adicional = adicional;
        }

        public override double Pagamento()
        {
            return (base.Pagamento() + (Adicional *= 1.1));
        }

        public override string ToString()
        {
            return Nome
                 + " - "
                 + ", Pagamento: $"
                 + Pagamento().ToString("F2");
        }

    }
}
