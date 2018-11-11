using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Game
{
    public class OrdinaryPlayer : Base
    {

        public override List<int> Rand(List<int> Numbers)
        {
            Random random = new Random();
            Thread.Sleep(10);
            int rand= random.Next(40,140);           
            Numbers.Add(rand);
            Console.WriteLine("Ordinary Player "+rand);
            return Numbers;
        }
    }
}
