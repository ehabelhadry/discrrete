using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter the lower limit: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the upper limit: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect numbers between {0} and {1} are:", n1, n2);

            for (int i = n1; i <= n2; i++)
            {