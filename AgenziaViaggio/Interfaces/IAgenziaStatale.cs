using AgenziaViaggio.abstracts;

namespace AgenziaViaggio.Interfaces
{
    public interface IAgenziaStatale
    {
        public void CheckIn(Viaggio viaggio); 
        public Viaggio PrenotaViaggio(string Nome, string Cognome,string CF, string[] Tragitto );

    }
}   
