namespace AgenziaViaggio
{
    public class Viaggio
    {
         string nome;
         string cognome;
         string cf;
         string ticketId;

         string Nome { get; }
         string Cognome { get; }
         string CF { get; }

         public string TicketId { get; }
             

        public Viaggio(string Nome, string Cognome, string CF, string TicketId)
        {
            Nome = nome;
            Cognome = cognome;
            CF = cf;
            ticketId = TicketId;
        }
    }
}