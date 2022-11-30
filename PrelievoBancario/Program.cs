using System;

namespace PrelievoBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfaceVersion.Client client = new InterfaceVersion.Client();
            //client.Operations();

            DelegateVersion.Client  clientdel = new DelegateVersion.Client();
            clientdel.Operations();
        }
    }
    
}
