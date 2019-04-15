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
            Adicional *= 1.1;
        }

        public override double Pagamento(int horas, double valHora)
        {
            return (base.Pagamento(horas, valHora) + Adicional);
        }
    }
}
