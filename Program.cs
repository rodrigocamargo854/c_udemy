using System;

namespace c_udemy

 {
    class Program 
    {
        static void Main (string[] args) {
            var number = 0;
            Quarto[] vectors = new Quarto[10];

            Console.WriteLine ("How many rooms do you want to rent?");

            while (true) 
            {

                try
                {
                     number = int.Parse (Console.ReadLine ());
                     break;
                    
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine ("Apenas números por favor!");
                    return;
                }
            }
           

            if (number != 0)

            {
                //Percorre somente o limite digitado
                for (int i = 1; i <= number; i++)
                 {
                    Console.Write ("Name  ");
                    string name = Console.ReadLine ();
                    Console.Write ("Email  ");
                    string email = Console.ReadLine ();
                    Console.Write ("Room  ");
                    int room = int.Parse (Console.ReadLine ());

                    vectors[room] = new Quarto (name, email);

                }

                Console.WriteLine("Quartos ocupados");
                Console.ReadKey();
                // percorre o vetor original(tamanho)
                for (int i = 0; i < 10; i++)

                {
                    if (vectors[i] != null)
                    {
                        Console.WriteLine( $"{i} , {vectors[i]}");
                    }
                }
            }
        }
    }
}