using System;
using AulaEnumEntites;
using AulaEnumEntites.Enums;



namespace AulaEnumEntites
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 0214,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            System.Console.WriteLine($"Dados do produto {order}" );

            // convertendo este valor enumerado para string

            string txt = OrderStatus.Delivered.ToString();
            string txt2 = OrderStatus.PendingPayment;
            System.Console.WriteLine( txt);


            // String para Enumerado

            // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            // System.Console.WriteLine(os);

        }
    }
}
