using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class UberPlayer : Base
    {
        public int rand = 39;
        public override List<int> Rand(List<int> Numbers)
        {
            rand = rand + 1;                       
            Numbers.Add(rand);
            Console.WriteLine("Uber Player "+ rand);
            return Numbers;
        }
    }
}
