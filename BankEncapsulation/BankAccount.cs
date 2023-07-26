﻿namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {
        }

        public void Deposit(double money)
        {
            balance += money;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double money)
        {
            balance -= money;
        }
    }
}