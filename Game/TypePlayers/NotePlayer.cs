using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game
{
    public class NotePlayer : Base
    {
        List<int> NoteList = new List<int>();
        public int NewRand { get; set; }
        public override List<int> Rand(List<int> Numbers)
        {
            Random random = new Random();
            Thread.Sleep(15);
            NewRand = random.Next(40, 140);

            if (NoteList.Contains(NewRand))
            {
                NewRand = random.Next(40, 140);
            }

            NoteList.Add(NewRand);
            Numbers.Add(NewRand);
            Console.WriteLine("Note Player " + NewRand);
            return Numbers;
        }
    }
}
