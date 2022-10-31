using AgenziaViaggio.Interfaces;
using System;

namespace AgenziaViaggio
{
    public class Ticket
    {
        public IAgenziaStatale agenziaStatale;
        public IAgenziaViaggio agenziaViaggio;
        public Viaggiatore viaggiatore;
        DateTime date;
        Tragitto tragitto;
        Mezzo mezzo; 

        public Ticket(IAgenziaViaggio AgenziaViaggio,IAgenziaStatale AgenziaStatale, Viaggiatore Viaggiatore )
        {
            agenziaStatale = AgenziaStatale;
            agenziaViaggio = AgenziaViaggio;
            viaggiatore = Viaggiatore;
            SetViaggioDate(); 
        }
        void SetViaggioDate()
        {
            RandomDay(); 
        }
        public void SetTragito(Tragitto Tragitto)
        {
            tragitto = Tragitto;
        }
        void RandomDay()
        {
           Random gen = new Random();
            DateTime start = DateTime.Today;
            int range = (DateTime.Today - start).Days;
            date =  start.AddDays(gen.Next(range));
        } 
        public void IniziaViaggio()
        {
            agenziaStatale.CheckIn(this); 
        }

        //public void SetViaggiatore(Viaggiatore Viaggiatore)
        //{
        //    viaggiatore = Viaggiatore;
        //    viaggiatore.viaggio = this; 
        //}
    }
}
