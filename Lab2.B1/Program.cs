using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.B1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài 1a:");
            var x = 10;
            void bai1a()
            {
                Console.WriteLine("X: " + x);
            }
            bai1a();
            Console.WriteLine();

            Console.WriteLine("Bài 1b: ");
            void getDatail(dynamic value)
            {
                Console.WriteLine("Value: " + value);
            }

            void bai1b()
            {
                getDatail(10);
                getDatail("Game");
            }
            bai1b();
            Console.WriteLine();


            Console.WriteLine("Bài 1c: ");
            UserData userData = new UserData(0, "First Player", 0);
            userData.ShowData("Level: ", userData.level);
            userData.ShowData("id: ", userData.id);
            userData.ShowData("Username ", userData.userName);
            Console.WriteLine();
            Console.Read();
        }
    }
}
