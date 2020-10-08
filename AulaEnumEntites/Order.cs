using System;
using AulaEnumEntites.Enums;

namespace AulaEnumEntites
{
     class Order // não é public
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status  { get; set; }

        public override string ToString()
        {
            return Id
            +","
            +Moment
            +","
            +Status;
        }

    }
}