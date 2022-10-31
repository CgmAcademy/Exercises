using AgenziaViaggio.Interfaces;
using System;

namespace AgenziaViaggio.abstracts
{
    public abstract class Agenzia : IAgenziaStatale
    {

        public abstracts.Ticket[] viaggi;
        public abstract void CheckIn(Viaggio viaggio);
        public abstract Viaggio PrenotaViaggio(string Nome, string Cognome, string CF, string[] Tragitto);

      

        protected class Ticket
        {
            //public IAgenziaStatale agenziaStatale;
            //public IAgenziaViaggio agenziaViaggio;
            protected abstracts.Ticket viaggiatore;
            DateTime date;
            Tragitto tragitto;
            Mezzo mezzo;

            public Ticket(
               // IAgenziaViaggio AgenziaViaggio,
               //IAgenziaStatale AgenziaStatale,
                 string Nome, string Cognome, string CF, string[] Tragitto
                )
            {
                //agenziaStatale = AgenziaStatale;
                //agenziaViaggio = AgenziaViaggio;
               // viaggiatore = Viaggiatore;
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

    }
}
