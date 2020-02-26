using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_196.Service
{
    interface PaypalOnline
    {
        double ValPaypal(double quantia, int numParcela);
        double PagtoJuros(double quantia);
    }
}
