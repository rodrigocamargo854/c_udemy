using System;
using AulaEnum_Entites;
using AulaEnum_Entites.Enum;

namespace AulaEnum_Entites
{
    class Program
    {
        static void Main(string[] args)
        {
           Order order = new Order
           {

               Id = 1080,
               Moment = DateTime.Now,
               Status = OrderStatus.PendingPayment 


           };
            Console.WriteLine(order);
            

        }
    }
}
