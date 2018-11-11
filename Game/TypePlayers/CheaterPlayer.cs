using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game
{
    public class CheaterPlayer : Base
    {
        public int rand;
        public override List<int> Rand(List<int> Numbers)
        {
            Random random = new Random();
            Thread.Sleep(9);

            int rand = random.Next(40, 140);
            if (Numbers.Contains(rand))
            {
                rand = random.Next(40, 140);
            }
            Numbers.Add(rand);
            Console.WriteLine("Cheater Player " + rand);
            return Numbers;
        }
    }
}
