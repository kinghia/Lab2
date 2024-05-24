using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.B2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            Action<int> anoMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Sub: " + sub);
            };
            anoMethod(5);
            Console.ReadLine();
        }
    }
}
