using System;

namespace Course_IComparable.Entities {
    class Funcionario:IComparable {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvEmpregado) {
            string[] vetor = csvEmpregado.Split(';');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1]);
        }

        public override string ToString() {
            return Nome + ", " +  Salario.ToString("F2");
        }

        public int CompareTo(object obj) {
            if(!(obj is Funcionario)) {
                throw new ArgumentException("Erro de Comparação: Argumento não é funcionário");
            }
            Funcionario outro = obj as Funcionario;
            return Nome.CompareTo(outro.Nome);

        }
    }
}
