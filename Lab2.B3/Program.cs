using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };
            userData userData = new userData(11095, "Huu Nghia", ldata);

            Console.WriteLine("ID: ");
            string ID = Console.ReadLine();
            userData.ID = Convert.ToInt32(ID); 
            Console.WriteLine("User Name: " );
            string UserName = Console.ReadLine();
            Console.WriteLine("Scores: ");
            foreach (float score in userData.Scores)
            {
                Console.WriteLine(score);
            }
            Console.ReadLine();
        }
    }
}
