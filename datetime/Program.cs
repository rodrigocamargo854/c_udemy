using System;
using System.Globalization;
namespace datetime

{
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("DateTime ");

            // DateTime d1 = DateTime.Now; // retorna a data atual do sistema
            // Console.WriteLine (d1);
            // Console.WriteLine (d1.Ticks); // retorna um tipo de contador de nano segundos
            // //Sobrecargas do Datetime total 12
            // DateTime d2 = new DateTime (2020, 9, 15); // retorna o horario atual
            // Console.WriteLine (d2);

            // DateTime d3 = new DateTime (2020, 9, 15, 20, 2, 3); // imprime data hora
            // Console.WriteLine (d3);

            // DateTime d6 = DateTime.Today; // retorna a data atual do sistema
            // Console.WriteLine(d6);

            // Utilizando Parse
            //Converte texto para data no formato de bd
            DateTime p1 = DateTime.Parse ("2000-08-15");
            Console.WriteLine (p1);

            //Converte texto para data no formato de bd
            DateTime p2 = DateTime.Parse ("2000-08-15 13:05:58");
            Console.WriteLine (p2);

            //Outro formato
            DateTime p3 = DateTime.Parse ("2000/08/15");
            Console.WriteLine (p3);

            // Parseexact com mascara
            DateTime p4 = DateTime.ParseExact("2000-08-15" , "yyyy-MM-dd" , CultureInfo.InvariantCulture);
            Console.WriteLine (p4);

            DateTime p5 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss" , CultureInfo.InvariantCulture);
            Console.WriteLine (p5);







        }
    }
}