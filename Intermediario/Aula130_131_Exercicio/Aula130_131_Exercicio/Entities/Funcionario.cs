using System;
using System.Collections.Generic;
using System.Text;

namespace Aula130_131_Exercicio.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrab { get; set; }
        public double ValHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int horasTrab, double valHora)
        {
            Nome = nome;
            HorasTrab = horasTrab;
            ValHora = valHora;
        }

        public virtual double Pagamento(int horas, double valHora)
        {
            return horas * valHora;
        }

        public override string ToString()
        {
            return Nome
                 + " - "
                 + ", Pagamento: $"
                 + Pagamento(HorasTrab, ValHora);
        }
    }
}
