using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ProgramGame<T>
    {
        OrdinaryPlayer ordinary = new OrdinaryPlayer();
        NotePlayer note = new NotePlayer();
        UberPlayer uber = new UberPlayer();
        CheaterPlayer cheater = new CheaterPlayer();
        UberCheaterPlayer uberCheater = new UberCheaterPlayer();

        public int Weight { get; set; }
        public int Amount { get; set; }
       
        public ProgramGame(int weigth, int amount)
        {
            Weight = weigth;
            Amount = amount;            
        }
        List<object> TypeList = new List<object>();

        List<int> Numbers = new List<int>();

        public void Options()
        {
            Console.WriteLine("1 - Ordinary Player");
            Console.WriteLine("2 - Notebook Player");
            Console.WriteLine("3 - Uber Player");
            Console.WriteLine("4 - Cheater Player");
            Console.WriteLine("5 - UberCheater Player");

            while (Amount != 0)
            {
                Console.Write("This player will be ");
                Int32.TryParse(Console.ReadLine(), out int type);
                
                Amount = Amount - 1;
                switch (type)
                {
                    case 1:
                        GetTypePlayer(ordinary);
                        break;

                    case 2:
                        GetTypePlayer(note);
                        break;

                    case 3:
                        GetTypePlayer(uber);
                        break;

                    case 4:
                        GetTypePlayer(cheater);
                        break;

                    case 5:
                        GetTypePlayer(uberCheater);
                        break;
                }
            }
        }

        public void GetTypePlayer<T>(T obj)
        {
            // Console.WriteLine(obj.GetType().Name);
            TypeList.Add(obj.GetType().Name);
            if (Amount == 0)
            {
                RandomGame();
            }
        }

        public void RandomGame()
        {
            int finish = 100;
            while ( finish>0)
            {
                Console.WriteLine();
                foreach (var i in TypeList)
                {
                    if (i.ToString() == ordinary.GetType().Name.ToString())
                        ordinary.Rand(Numbers);

                    else if (i.ToString() == note.GetType().Name.ToString())
                        note.Rand(Numbers);

                    else if (i.ToString() == uber.GetType().Name.ToString())
                        uber.Rand(Numbers);

                    else if (i.ToString() == cheater.GetType().Name.ToString())
                        cheater.Rand(Numbers);

                    else
                        uberCheater.Rand(Numbers);


                    if (Numbers.Contains(Weight))
                    {
                        Console.WriteLine("This Player has won the game. Congratulations!!!");
                        finish = 0;
                        break;
                    }
                    
                    finish = finish - 1;                    
                }

               
            }
        }
    }
}
