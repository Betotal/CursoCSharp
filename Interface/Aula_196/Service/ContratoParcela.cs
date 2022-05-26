<<<<<<< HEAD
﻿using System;
using Aula_196.Entities;
using System.Collections.Generic;
using System.Text;

namespace Aula_196.Service
{
    class ContratoParcela
    {
        private PaypalOnline _paypalOnline;


        public ContratoParcela(PaypalOnline onlinePaypal)
        {
            _paypalOnline = onlinePaypal;
        }

        public void ProcessaContrato(Contrato contrato, int parcelas)
        {
            double ValorPrestacao = contrato.valContrato / parcelas;
            for (int i = 1; i <= parcelas; i++)
            {
                DateTime date = contrato.dtContrato.AddMonths(i);
                double AtualizaPrestacao = ValorPrestacao + _paypalOnline.ValPaypal(ValorPrestacao, i);
                double TotalPrestacao = AtualizaPrestacao + _paypalOnline.PagtoJuros(AtualizaPrestacao);
                contrato.AddParcela(new Parcela (date, TotalPrestacao));
            }
        }

    }
}
=======
﻿using System;
using Aula_196.Entities;
using System.Collections.Generic;
using System.Text;

namespace Aula_196.Service
{
    class ContratoParcela
    {
        private PagtoOnline _pagtoOnline;


        public ContratoParcela(PagtoOnline onlinePaypal)
        {
            _pagtoOnline = onlinePaypal;
        }

        public void ProcessaContrato(Contrato contrato, int parcelas)
        {
            double ValorPrestacao = contrato.valContrato / parcelas;
            for (int i = 1; i <= parcelas; i++)
            {
                DateTime date = contrato.dtContrato.AddMonths(i);
                double AtualizaPrestacao = ValorPrestacao + _pagtoOnline.ValPagto(ValorPrestacao, i);
                double TotalPrestacao = AtualizaPrestacao + _pagtoOnline.PagtoJuros(AtualizaPrestacao);
                contrato.AddParcela(new Parcela (date, TotalPrestacao));
            }
        }

    }
}
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962
