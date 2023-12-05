using System;

namespace Lub_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Alex", "Current");
            account.Deposit(350);
            account.Deposit(100);
            account.Withdraw(200);

            Console.WriteLine($"{account[2].DateTransaction}, {account[2].Summa}, {account[2].NameTransaction}");

            Build[] builds =
            {
                new Build(1, 3, 2),
                new Build(2, 3, 2),
                new Build(3, 3, 2),
                new Build(4, 3, 2),
                new Build(5, 5, 3),
                new Build(6, 5, 3),
                new Build(7, 5, 3),
                new Build(8, 5, 3), //7
                new Build(9, 5, 3),
                new Build(10, 10, 4),
            };
            GroupBuilds groupBuilds1 = new GroupBuilds(builds);
            Console.WriteLine("\n" + groupBuilds1[7].NumberApartments);
            Console.ReadKey();
        }
    }
}
