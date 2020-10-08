using System;

namespace ref_out
{
    class Program
    {
        static void Main(string[] args)
        {

           int a = 10;
           int triple;
           
           // insiro o resultado de a em Triple
           Calculator2.Triple(a, out triple);
           Console.WriteLine(triple);

        }
    }
}
