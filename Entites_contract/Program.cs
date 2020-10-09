using System;
using Entites;
using Enum;
using System.Globalization;

namespace Entites_contract
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write( "Departament name: ");
            string deptName = Console.ReadLine();
            System.Console.Write( "Enter Worker Name: ");
            string name = Console.ReadLine();
            System.Console.Write( "Level ");
            WorkLevel level = Enum.parse<WorkLevel>(Console.ReadLine());

            System.Console.Write( "Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Departament deptName = new Departament(deptName);
            Worker worker = new Worker(name,level,baseSalary,dept);

            System.Console.WriteLine("Howmany contracts");
            






            
            

        }
    }
}
