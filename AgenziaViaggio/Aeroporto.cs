using AgenziaViaggio.Interfaces;

namespace AgenziaViaggio
{
    public class Aeroporto : Agenzia, IAgenziaStatale
    {
        string nome; 
        public void CheckIn(Ticket viaggio) 
        {
            System.Console.WriteLine($"CheckIn pressp Aeroporto di  {viaggio.tr}");

            System.Console.WriteLine($"CheckIn effettuato per {viaggio.viaggiatore.Nome}");
        }

    }
}
