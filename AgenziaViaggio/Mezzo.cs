using System;
using System.Linq;

namespace AgenziaViaggio
{
    internal class Mezzo
    {
        bool[] posti;

        public Mezzo()
        {  
            Random random = new Random();   
            posti = new bool[random.Next(1,200)];
        } 
        public int GetPostiDisponibili()
        {
            return posti.Where(i => i == false).ToArray().Count(); 
        }
        public int PrenotaPosto()
        {
            return posti.Where(i => i == false).ToArray().Count();
        }
    }
}