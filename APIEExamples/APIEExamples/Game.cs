using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal class Game : Media
    {
        
        public int copies;
        public bool IsCoop;
        public int TimePlayed;
        // child class
        public int MaxLevel;
        public List<string> Inventory;


        public void Play()
        {
            Console.WriteLine("How many hours did you play today?");
            int hours = Int32.Parse(Console.ReadLine());
            TimePlayed += hours;
        }

        public void Play(int hours)
        {
            TimePlayed += hours;
        }
    }
}
