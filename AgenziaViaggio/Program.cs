using AgenziaViaggio.Interfaces;
using System;

namespace AgenziaViaggio
{
    internal class Program
    {    
       
        static void Main(string[] args)
        {
            Viaggio viaggio = null;
            IAgenziaViaggio agenziaViaggio = null;
            IAgenziaStatale agenziaStatale = null;  
            string nome;
            string Cognome;
            string CF;
            string[] Tragitto; 


            // Creare Il tipo di viaggio 

            Console.WriteLine("Scegliere tra i tipi di viaggio:");
            Console.WriteLine("1 - Treno");
            Console.WriteLine("2 - Aereo");
            Console.WriteLine("3 - Nave");

            int viaggioInput;
            do
            {
                viaggioInput = Convert.ToInt32(Console.ReadLine());

            } while (viaggioInput == 0);



            // Creare Il tipo di agenzia per l'acquisto 

            Console.WriteLine("Come vuoi comprare il biglietto? ");
            Console.WriteLine("1 - Agenzia Online");
            Console.WriteLine("2 - Direttamente dal Rivenditore");
            
            int agenziaInput;
            do
            {
                agenziaInput = Convert.ToInt32(Console.ReadLine());

            } while (agenziaInput != 1 && agenziaInput != 2 );

            //if(agenziaInput == 1)
            //{
            //    agenziaViaggio = new AgenziaOnline(); 
            //}


            // Creare viaggiatore 
            char datiUtenteInput;
            do
            {
                Console.WriteLine("Inserire i tuoi dati:  ");

                Console.WriteLine(" Nome:");
                 nome = Console.ReadLine();

                Console.WriteLine(" Cognome:");
                 Cognome = Console.ReadLine();

                Console.WriteLine(" CF:");
                 CF = Console.ReadLine();

                Console.WriteLine(" I Dati sono Corretti? Y / N ");
                agenziaInput = Convert.ToChar(Console.ReadLine());


            } while (agenziaInput == 'N');

              
            //  Viaggiatore viaggiatore = new Viaggiatore(nome, Cognome, CF);
            
            switch (viaggioInput)
            { 
                case 1:
                    agenziaStatale = new Ferrovie();
                    viaggio = agenziaViaggio.PrenotaViaggio(nome, Cognome, CF, new string[] {}) ;
                    break; 
                case 2:
                    agenziaStatale = new Aeroporto();
                    viaggio = agenziaViaggio.PrenotaViaggio(nome, Cognome, CF, new string[] { });
                    break;
                case 3:
                    agenziaStatale = new Porto();
                    viaggio = agenziaViaggio.PrenotaViaggio(nome, Cognome, CF, new string[] { });
                    break;
            }
        }
    }
}
