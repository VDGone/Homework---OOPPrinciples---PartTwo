using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankАccounts
{
    public class TestBank
    {
        static void Main()
        {
            Bank bank = new Bank("WeStealYourMoney");

            Customers firstOwner = new Customers("Ivan Georgiev");
            DepositAccount deposit = new DepositAccount(firstOwner, 16034, 4.5m);
            bank.AddAccount(deposit);

            Customers secondOwner = new Customers("Iliana Ignatova");
            MortgageAccount mortage = new MortgageAccount(secondOwner, 600, 4.5m);
            bank.AddAccount(mortage);

            Customers ThirdOwner = new Customers("Milen Minev");
            LoanAccount loan = new LoanAccount(ThirdOwner, 800, 6.5m);
            bank.AddAccount(loan);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.accounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.accounts[i]);
            }
        }
    }
}
