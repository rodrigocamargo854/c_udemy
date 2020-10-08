using System;

namespace datatimekind {
    class Program {
        static void Main (string[] args) {
            //muData.TotalLocalTime() converte para o horario local
            //myDate.ToUniversalTime() converte para o horario universal
            //DateTimes overloads DateTime(ano, mes, dia, horas ,minutos, segundos, DatetimeKind.Local ) horario local
            //DateTimes overloads DateTime(ano, mes, dia, horas ,minutos, segundos, DatetimeKind.Utc ) horario local

            DateTime d1 = new DateTime (2020, 4, 23, 13, 52, 52, DateTimeKind.Local);
            DateTime d2 = new DateTime (2020, 4, 23, 13, 52, 52, DateTimeKind.Utc);
            DateTime d3 = new DateTime (2020, 4, 23, 13, 52, 52, DateTimeKind.Utc);

            //Formato Padrão ISO 8601

            //formato
            // yyyy-MM-DDTHH:mm:ssZ
            //z indica que a hora esta em utc

            DateTime d4 = DateTime.Parse ("2000-08-15 13:05:01");
            Console.WriteLine (d4);

            DateTime d5 = DateTime.Parse ("2000-08-15T13:05:01Z");
            Console.WriteLine (d5);

            Console.WriteLine ($"d1 {d1}");
            Console.WriteLine ($"d1 Kind {d1.Kind}");
            Console.WriteLine ($"d1 to Local {d1.ToLocalTime()}"); //horario local atrasado 3 horas em relação ao universal
            Console.WriteLine ($"d1 to universal time {d1.ToUniversalTime()}"); //acrescenta  3 horas

            Console.WriteLine ($"d2 {d2}");
            Console.WriteLine ($"d2 Kind {d2.Kind}");
            Console.WriteLine ($"d2 to Local {d2.ToUniversalTime()}"); //horario universal adiantado 3 horas em relação ao universal
            Console.WriteLine ($"d2 to universal time {d2.ToLocalTime()}"); //sub  3 horas
            
            //primeiro passar para o universal time para depois passar para a forma iso9001
            Console.WriteLine ($"d2 to universal time {d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")}"); //sub  3 horas
            Console.WriteLine ($"d2 to universal time {d3.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")}"); //sub  3 horas

        }

    }
}