using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeCamp_5._0_Task_5
{
    internal class BankAccount
    {
        public string AccountNumber { set; get; }
        public string AccountHolder { set; get; }
        public decimal Balance { set; get; }

        public BankAccount(string accountnumber, string accountholder)
        {
            AccountNumber = accountnumber;
            AccountHolder = accountholder;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Your Deposit amount should be more than zero");
            }

            else
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful!,New Balance: {Balance}");

            }

        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds");
            }

            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal Amount must be greater than zero");
            }

            else 
            {
                Balance -= amount;
                Console.WriteLine($"Current Balance is {Balance}");
            }
            
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is {Balance}");
        }

    }
}
