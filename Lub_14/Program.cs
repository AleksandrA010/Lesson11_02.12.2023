using Lub_13;
using System;

namespace Lub_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Gordon", "Current");
            account.DumpToScreen();
            Console.ReadKey();
        }
    }
}
