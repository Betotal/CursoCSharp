using System.Globalization;

namespace Exerc_Aula78_List {
    class Funcionario {
        public int IdFunc { get; private set; }
        public string NomeFunc { get; private set; }
        public double SalarioFunc { get; private set; }

        public Funcionario() {
        }

        public Funcionario(int _id, string _nome, double _salario) {
            IdFunc = _id;
            NomeFunc = _nome;
            SalarioFunc = _salario;
        }

        public void AlteraSalario(double porcentagem) {
            SalarioFunc *= (porcentagem / 100) + 1;
        }

        public override string ToString() {
            return "Funcionário: Id: " + IdFunc +
                   " - Nome: " + NomeFunc +
                   " - Salário: " + SalarioFunc.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
