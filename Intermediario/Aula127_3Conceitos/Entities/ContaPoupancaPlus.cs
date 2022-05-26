using System;
using System.Collections.Generic;
using System.Text;

namespace Aula127_3Conceitos.Entities
{
    
    class ContaPoupancaPlus : ContaPoupanca   //Nâo é permitido, pois a classe ContaPoupanca estivesse selada
    {
 //       public override void RetiradaSaldo(double quantia)  // se o método estiver selado, não será possível implementa-lo
 //       {
 //           base.RetiradaSaldo(quantia);
 //       }
    }
    
}
