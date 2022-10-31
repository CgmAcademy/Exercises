using AgenziaViaggio.abstracts;
using AgenziaViaggio.Interfaces;

namespace AgenziaViaggio
{
    public class Ferrovie : Agenzia
    {
        public void CheckIn() { }

        public override void CheckIn(Viaggio viaggio)
        {
            throw new System.NotImplementedException();
        }

        public override Viaggio PrenotaViaggio(string Nome, string Cognome, string CF, string[] Tragitto)
        {
            throw new System.NotImplementedException();
        }
    }
}
