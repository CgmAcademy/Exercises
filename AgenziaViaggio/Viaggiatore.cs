namespace AgenziaViaggio
{
    public class Viaggiatore
    {
         string nome;
         string cognome;
         string cf;
        public Ticket viaggio; 
        public string Nome { get {return $"{nome} {cognome}"; } }     

        public Viaggiatore(string Nome, string Cognome, string CF)
        {
            Nome = nome;
            Cognome = cognome;
            CF = cf;
        }
    }
}