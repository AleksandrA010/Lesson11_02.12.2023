using System;
using System.Collections;
using System.Collections.Generic;

namespace Lub_13
{
    internal class Account
    {
        private static int _staticAccountNumber = 102200;
        private int _accountNumber;
        private double _balance;
        private string _fullName;
        private string _accountType;
        public List<BankTransaction> BankTransaction { get; private set; }
        public string AccountType { get { return _accountType; } }
        public int AccountNumber { get { return _accountNumber; } }
        public double Balance { get { return _balance; } }
        public string FullName { get { return _fullName; } } //Держатель счёта
        public BankTransaction this[int index]
        {
            get
            {
                return BankTransaction[index];
            }
        }
        public Account(string fullName, string accountType)
        {
            _accountNumber = _staticAccountNumber++;
            _balance = 0;
            _fullName = fullName;            
            _accountType = accountType;
            BankTransaction = new List<BankTransaction>();
        }
        public void Deposit(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nОшибка!\nВы пытаетесь положить отрицательную сумму!");
            }
            else
            {
                _balance += money;
                BankTransaction.Add(new BankTransaction(money, "Deposit"));
            }
        }
        public void Withdraw(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nОшибка!\nВы пытаетесь взять отрицательную сумму!");
            }
            else if (money > _balance)
            {
                Console.WriteLine("\nНа вашем счёте не достаточно средств!");
            }
            else
            {
                _balance -= money;
                BankTransaction.Add(new BankTransaction(money, "Withdraw"));
            }
        }
    }
}
