using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal class Movie : Media
    {
        
        public double Rating;
        public List <string> Cast;
        public List<string> Crew;
        public double Duration;
        public bool AwardWinning;
        public bool InTheatres;

        public void Play()
        {
            Console.WriteLine("I sure wish Christian Bale was in this movie!");
        }

    }
}
