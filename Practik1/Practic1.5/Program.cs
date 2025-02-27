using Practik1;
using System;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new InterestEarningAccount("KJLjlkjl", 1000);
            var account2 = new InterestEarningAccount("KJLjlkjl", 1000);
            
            try
            {
                account1.MakeDeposit(200, DateTime.Now, "lolololo");
                Console.WriteLine(
                $"Account {account1.HistoryOfTransactions()}");
                Console.WriteLine($"Account balance: {account1.Balance}");

                account2.MakeDeposit(1000, DateTime.Now, "lolololo");
                account2.MakeWithdrawal(100, DateTime.Now, "kfdas;");
                Console.WriteLine($"Account {account2.HistoryOfTransactions()},");
                Console.WriteLine($"Account balance: {account2.Balance}");

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message, e.ParamName, e.ToString());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }
            finally
            {
                Console.WriteLine($"Account {account1.Number.Value}");
            }
        }
    }
}

