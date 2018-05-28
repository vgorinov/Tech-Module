using System;

namespace _01_BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }



        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }


        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }


        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }


        static void PrintReceipt()
        {
            Header();
            Body();
            Footer();
        }
    }
}
