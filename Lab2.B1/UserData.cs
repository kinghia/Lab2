using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.B1
{
    public class UserData
    {
        public int id;
        public string userName;
        public int level;
        public UserData (int id, string userName, int level)
        {
            this.id = id; 
            this.userName = userName;
            this.level = level;
        }
        public void ShowData()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("UserName: " +  userName);
            Console.WriteLine("Level: " + level);
        }
        public void ShowData (string name, dynamic attribute)
        {
            Console.WriteLine(name + ": " +  attribute);
        }
    }
}
