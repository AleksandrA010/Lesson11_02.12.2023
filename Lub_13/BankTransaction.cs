using System;

namespace Lub_13
{
    internal class BankTransaction
    {
        public DateTime DateTransaction { get; }
        public double Summa { get; }
        public string NameTransaction {  get; }

        public BankTransaction(double summa, string nameTransaction)
        {
            Summa = summa;
            DateTransaction = DateTime.Now;
            NameTransaction = nameTransaction;
        }

    }
}
