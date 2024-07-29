using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Account
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public const double MIN_BALANCE = 500;

        public Account() { }
        public Account(double id, string name, string bankName)
        {
            Id = id;
            Name = name;
            BankName = bankName;
        }
        public Account(double id, string name, double balance, string bankName) : this(id, name, bankName)
        {
            if (balance < MIN_BALANCE)
            {

                balance = MIN_BALANCE;

            }
            {
                Balance = balance;
            }

        }
        public double Deposit(double amount)
        {
            Balance = amount + Balance;
            return Balance;

        }
        public double Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                return Balance;

            }
            {
                return -1;
            }
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Id is " + account.Id);
            Console.WriteLine("Name is " + account.Name);
            Console.WriteLine("BankName is " + account.BankName);
            Console.WriteLine("Balance is " + account.Balance);


        }
    }
}

