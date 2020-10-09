using System;


namespace Entites
{
    public class HourContract
    {
        public  Datetime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        
         public HourContract()
        {
           
        }
        public HourContract(Datetime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour *Hours;

        }


    }
}