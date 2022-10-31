namespace AgenziaViaggio.Interfaces
{
    public interface IAgenziaViaggio
    {
        public Viaggio PrenotaViaggio(string Nome, string Cognome,string CF, string[] Tragitto );
    }
}
