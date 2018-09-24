using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            //  Console.WriteLine("what is your first number?");
            //  int num1 = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("what is your  number?");
            //  int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Add(num1, num2));
            Console.WriteLine(Subtract(num1, num2));
            Console.WriteLine(Multiply(num1, num2));
            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        private static int Multiply(int num1, int num2) => num1 * num2;
        private static int Subtract(int num1, int num2) => num1 - num2;
        private static int Add(int num1, int num2) => num1 + num2;
    }
}
