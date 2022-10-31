using AgenziaViaggio.Interfaces;
using System;

namespace AgenziaViaggio.abstracts
{
    public abstract class Ticket
    {
        public IAgenziaStatale agenziaStatale;
       // public IAgenziaViaggio agenziaViaggio;
        public Ticket viaggiatore;
        DateTime date;
        Tragitto tragitto;
        Mezzo mezzo;

        public Ticket(IAgenziaViaggio AgenziaViaggio, IAgenziaStatale AgenziaStatale, Ticket Viaggiatore)
        {
            agenziaStatale = AgenziaStatale;
           // agenziaViaggio = AgenziaViaggio;
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
            date = start.AddDays(gen.Next(range));
        }       

    }
    public class TrainTicket : Ticket 
    {
        public TrainTicket(IAgenziaViaggio AgenziaViaggio, IAgenziaStatale AgenziaStatale, Ticket Viaggiatore) 
            : base (AgenziaViaggio, AgenziaStatale, Viaggiatore)
        {
            agenziaStatale = AgenziaStatale;
            //agenziaViaggio = AgenziaViaggio;
            viaggiatore = Viaggiatore;
          //  SetViaggioDate();
        }
       

    }
                            
        
}
