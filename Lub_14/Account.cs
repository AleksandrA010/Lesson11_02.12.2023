#define typeA
//#define typeB
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
        public string AccountType { get { return _accountType; } }
        public int AccountNumber { get { return _accountNumber; } }
        public double Balance { get { return _balance; } }
        public string FullName { get { return _fullName; } } //Держатель счёта
        public void DumpToScreen()
        {
#if typeA
            Console.WriteLine("Выводит вариант 1");
#endif
#if typeB
            Console.WriteLine("Выводит вариант 2");
#endif
        }
        public Account(string fullName, string accountType)
        {
            _accountNumber = _staticAccountNumber++;
            _balance = 0;
            _fullName = fullName;            
            _accountType = accountType;
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
            }
        }
    }
}
