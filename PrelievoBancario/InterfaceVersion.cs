using System;

namespace PrelievoBancario
{
    public partial class InterfaceVersion
    {
        public class ATM 
        {
            public COUNTRY cOUNTRY { get; set; } = COUNTRY.DE;

            public void WithDraw(ICircuitoInternazionale circuito, decimal amount)
            {
                circuito.WithDraw(amount);
                
            }
            public void Deposit(ICircuito circuito, decimal amount)
            {
                circuito.Deposit(amount);
            }
            public void CheckConto(ICircuito circuito)
            {
                circuito.CheckConto();
               
            }

        }
        public class Conto : ICircuito
        {
            public COUNTRY cOUNTRY { get; set; } = COUNTRY.FR;

            decimal Saldo;
            public void WithDraw(decimal amount)
            {
               
                Saldo -= amount;
                Console.WriteLine($"Prelievo di {amount} EURO effettauto con successo ");
            }
            public void Deposit(decimal amount)
            {               
                Saldo += amount;
                Console.WriteLine($"Deposito di {amount} EURO effettauto con successo ");

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
                Conto Unicredit = new Conto();//bancomat
                ATM aTMGermania = new ATM();

                aTMGermania.WithDraw(Unicredit, 1000M);
                aTMGermania.CheckConto(Unicredit);
                aTMGermania.Deposit(Unicredit, 1000M);
                aTMGermania.CheckConto(Unicredit);
            }
        }
    }
}
