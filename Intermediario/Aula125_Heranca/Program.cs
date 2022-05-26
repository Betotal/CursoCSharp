using System;
using Aula125_Heranca.Entities;

namespace Aula125_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial conta = new ContaEspecial(102030, "Beto Reis", 1000.00, 350.00);

            Console.WriteLine(conta.Saldo);

<<<<<<< HEAD:Intermediario/Aula125_Heranca/Program.cs
 //           conta.Saldo = 500.00;   // por causa do acesso "protected" não é possivel atribuir valor, pelo programa.
=======
//            conta.Saldo = 500.00;   // por causa do acesso "protected" não é possivel atribuir valor, pelo programa.
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962:Intermediario/Aula125_Heranca/Aula125_Heranca/Program.cs
        }
    }
}
