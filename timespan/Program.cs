using System;

namespace timespan {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("TimeSpan");

            TimeSpan t1 = new TimeSpan ();
            System.Console.WriteLine (t1);

            TimeSpan t2 = new TimeSpan (9000000000L); //construtor nanosegndos
            System.Console.WriteLine (t2);

            TimeSpan t3 = new TimeSpan (2, 11, 21); //construtor hora, minutos e segundos
            System.Console.WriteLine (t3);

            TimeSpan t4 = new TimeSpan (1, 2, 11, 21); //construtor dias, hora, minutos e segundos
            System.Console.WriteLine (t4);

            TimeSpan t5 = new TimeSpan (1, 2, 11, 21,321); //construtor dias, hora, minutos ,segundos. milisegundos
            System.Console.WriteLine (t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5); //Dia fraccionado
            System.Console.WriteLine (t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5); //horas  fraccionado
            System.Console.WriteLine (t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5); //minutos  fraccionado
            System.Console.WriteLine (t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5); //segundos  fraccionado
            System.Console.WriteLine (t9);

            TimeSpan t10 = TimeSpan.FromSeconds(1.5); //milissegundos  fraccionado
            System.Console.WriteLine (t10);





        }
    }
}