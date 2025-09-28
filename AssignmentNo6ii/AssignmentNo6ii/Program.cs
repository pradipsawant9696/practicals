using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo6ii
{
    internal class Program
    {
        // Custom Exception for Minimum Balance
        class MinimumBalanceException : Exception
        {
            public MinimumBalanceException(string message) : base(message) { }
        }

        // Custom Exception for Daily Deposit Limit
        class DailyDepositException : Exception
        {
            public DailyDepositException(string message) : base(message) { }
        }

        // BankAccount Class
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; private set; }

            public BankAccount(int accNo, string name, double initialBalance)
            {
                AccountNumber = accNo;
                HolderName = name;
                Balance = initialBalance;
            }

            // Deposit Method
            public void Deposit(double amount)
            {
                if (amount > 100000)
                {
                    throw new DailyDepositException(
                        $"Deposit failed! You tried to deposit ₹{amount}. Daily deposit limit is ₹100000."
                    );
                }
                Balance += amount;
                Console.WriteLine($"₹{amount} deposited successfully! Current Balance: ₹{Balance}");
            }

            // Withdraw Method
            public void Withdraw(double amount)
            {
                if (Balance - amount < 1000)
                {
                    throw new MinimumBalanceException(
                        $"Withdrawal failed! After withdrawing ₹{amount}, balance would fall below ₹1000."
                    );
                }
                Balance -= amount;
                Console.WriteLine($"₹{amount} withdrawn successfully! Current Balance: ₹{Balance}");
            }

            // Display Account Info
            public void Display()
            {
                Console.WriteLine("\n--- Account Details ---");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Holder Name: {HolderName}");
                Console.WriteLine($"Balance: ₹{Balance}");
            }
        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(101, "Alice", 5000);

            try
            {
                account.Display();

                // Valid Deposit
                account.Deposit(50000);

                // Invalid Deposit
                account.Deposit(150000);
            }
            catch (DailyDepositException ex)
            {
                Console.WriteLine("\nException: " + ex.Message);
            }

            try
            {
                // Valid Withdraw
                account.Withdraw(3000);

                // Invalid Withdraw
                account.Withdraw(2000);
            }
            catch (MinimumBalanceException ex)
            {
                Console.WriteLine("\nException: " + ex.Message);
            }
        }
    }
}
