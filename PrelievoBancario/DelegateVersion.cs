using static PrelievoBancario.InterfaceVersion;
using System;

namespace PrelievoBancario
{
    class DelegateVersion
    {

        public delegate void ContoDelegate(decimal amount); 
        public class ATM
        {
            public COUNTRY country { get; set; } = COUNTRY.DE;
            bool isAbroad;
            public ATM(COUNTRY ContoCountry)
            {  
                isAbroad = country == ContoCountry ? true : false;                  
            }               

            public void WithDraw(Action<decimal> Action, decimal amount)
            {               
               Action(amount);               
            }            
            public void Deposit(Action<decimal> Action, decimal amount)
            {   


                if(isAbroad)
                   Action(amount);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Deposit Not Authorized");
                    Console.ResetColor();

                }

            }
            public void CheckConto(Action Action)
            {   

                if (isAbroad)
                    Action();
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" CheckConto Not Authorized");
                    Console.ResetColor();

                }


            }


        }
        public class Conto
        {
            public COUNTRY country { get; set; } = COUNTRY.FR;

            decimal Saldo;
            public void WithDraw(decimal amount)
            {
                Console.WriteLine($"Prelievo di {amount} EURO effettuato con successo ");
            }
            public void Deposit(decimal amount)
            {               
                Saldo += amount;
            }
            public void CheckConto()
            {               
                Console.WriteLine($"Saldo è di {Saldo} ");
            }
        }

        public class Client
        {
            public void Operations()
            {
                Action<decimal> withDrawDelegate,depositDelegate; 
                Action CheckDelegate;

                Conto Unicredit = new Conto();
                ATM aTMGermania = new ATM(Unicredit.country);


                withDrawDelegate = Unicredit.WithDraw;
                depositDelegate = Unicredit.Deposit;
                CheckDelegate = Unicredit.CheckConto;




                aTMGermania.WithDraw(withDrawDelegate, 1000M);               
                aTMGermania.CheckConto(CheckDelegate);
                aTMGermania.Deposit(depositDelegate, 1000M);
                aTMGermania.CheckConto(CheckDelegate);
            }
        }
    }
}
