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
