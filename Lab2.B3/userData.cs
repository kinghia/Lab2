using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.B3
{
    internal class userData
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public List<float> Scores { get; set; }

        public userData(int id, string userName, List<float> scores)
        {
            ID = id;
            UserName = userName;
            Scores = scores;
        }
    }
}
