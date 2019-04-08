using System;
using System.Collections.Generic;
using System.Text;

namespace Aula115_Enuns.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
