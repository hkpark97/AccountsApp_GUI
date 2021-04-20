using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount : Account
    {
        public const double TransactionFee = 0.30;
        public double WithdrawLimit { get; set; }

        public CheckingAccount(int number, string clientName, double balance, double withdrawLimit)
            : base(number, clientName, balance)
        {
            WithdrawLimit = withdrawLimit;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Balance -= TransactionFee;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            Balance -= TransactionFee;
        }
    }
}
