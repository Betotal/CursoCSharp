using System.Collections.Generic;
using Aula118_120_Composition.Entities.Enums;


namespace Aula118_120_Composition.Entities
{
    class Trabalhador
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departamento  Departamento { get; set; }

        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador()
        {
        }

        //Em uma relação Um para muitos, não deve passar a lista no construtor 
        public Trabalhador(string name, WorkerLevel level, double baseSalary, Departamento departamento)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departamento = departamento;
        }

        public void addContrato(HoraContrato contract)
        {
            Contratos.Add(contract);
        }

        public void removeContrato(HoraContrato contract)
        {
            Contratos.Remove(contract);
        }

        public double Ganho(int year, int month)
        {
            double Soma = BaseSalary;

            foreach(HoraContrato contract in Contratos)
            {
                if (contract.DataContrato.Year == year && contract.DataContrato.Month == month)
                {
                    Soma += contract.ValorTotal();
                }
            }
            return Soma;
        } 

    }
}
