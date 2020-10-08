using System;
using System.Globalization;
namespace datetime

{
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("DateTime ");

            DateTime d1 = DateTime.Now; // retorna a data atual do sistema
            Console.WriteLine (d1);
            Console.WriteLine (d1.Ticks); // retorna um tipo de contador de nano segundos
            // Sobrecargas do Datetime total 12
            DateTime d2 = new DateTime (2020, 9, 15); // retorna o horario atual
            Console.WriteLine (d2);

            DateTime d3 = new DateTime (2020, 9, 15, 20, 2, 3); // imprime data hora
            Console.WriteLine (d3);

            DateTime d6 = DateTime.Today; // retorna a data atual do sistema
            Console.WriteLine (d6);

            // Utilizando Parse
            // // Converte texto para data no formato de bd
            DateTime p1 = DateTime.Parse ("2000-08-15");
            Console.WriteLine (p1);

            //Converte texto para data no formato de bd
            DateTime p2 = DateTime.Parse ("2000-08-15 13:05:58");
            Console.WriteLine (p2);

            //Outro formato
            DateTime p3 = DateTime.Parse ("2000/08/15");
            Console.WriteLine (p3);

            // Parseexact com mascara
            DateTime p4 = DateTime.ParseExact ("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine (p4);

            DateTime p5 = DateTime.ParseExact ("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine (p5);

            //Propriedades

            DateTime x = new DateTime (2020, 9, 15, 13, 45, 58, 275);

            System.Console.WriteLine (x);
            System.Console.WriteLine (x.Date);
            System.Console.WriteLine (x.Month);
            System.Console.WriteLine (x.Day);
            System.Console.WriteLine (x.Hour);
            System.Console.WriteLine (x.Minute);
            System.Console.WriteLine (x.Second);

            Console.WriteLine (x.ToLongDateString ()); //retorna dia da semana mes e ano
            Console.WriteLine (x.ToLongTimeString ()); //retorna hora

            //Para converter a data em varios formatos

            System.Console.WriteLine ($">>>{x.ToLongDateString()}<<<<"); //data formatada
            System.Console.WriteLine ($">>>{x.ToShortDateString()}<<<<");
            System.Console.WriteLine ($">>>{x.ToLongTimeString()}<<<<");
            // colocando mascaras para formatacao em uma string

            string s9 = d1.ToString ("yyyy-MM-dd HH:mm;ss");
            System.Console.WriteLine (s9);

            //com ilisegundos
            string s10 = d1.ToString ("yyyy-MM-dd HH:mm;ss.fff");

            // operações com datas, horas meses
            System.Console.WriteLine (x.AddDays (2)); // adiciona dois dias
            System.Console.WriteLine (x.AddHours (2)); // adiciona dois dias
            System.Console.WriteLine (x.AddMilliseconds (2)); // adiciona dois dias
            System.Console.WriteLine (x.AddMinutes (2)); // adiciona dois dias
            System.Console.WriteLine (x.AddSeconds (2)); // adiciona dois dias
            System.Console.WriteLine (x.AddTicks (2)); // adiciona dois dias

            //Para subtrair duas datas

            DateTime dx = new DateTime (2000, 10, 10);

            DateTime dy = new DateTime (2000, 10, 18);
                    //data final      //data inicial
            Console.WriteLine(dy.Subtract(dx));

        }
    }
}