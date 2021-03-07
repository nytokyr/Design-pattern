using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.RetirerArgent(115100);
        }
    }
}
