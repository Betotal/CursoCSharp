using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_196.Service
{
    interface PagtoOnline
    {
        double ValPagto(double quantia, int numParcela);
        double PagtoJuros(double quantia);
    }
}
