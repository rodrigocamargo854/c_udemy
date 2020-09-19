

using System;

namespace AulaEnumEntites.Enums
{
    enum OrderStatus : int // herança
    {
        Processing = 0,
        PaymentPendig = 1,
        Shipped = 2,
        Delivery = 3
    }
}