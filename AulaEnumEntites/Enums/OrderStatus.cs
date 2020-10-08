

namespace AulaEnumEntites.Enums
{
    enum OrderStatus : int //  esse tipo sera utilizado na classe Order
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    };

}