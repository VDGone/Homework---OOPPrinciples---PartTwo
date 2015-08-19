namespace _02.BankАccounts
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private string bankName;
        public List<Account> accounts;

        public Bank(string bankName)
        {
            this.BankName = bankName;
            this.accounts = new List<Account>();
        }

        public string BankName
        {
            get 
            {
                return this.bankName; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be empty!");
                }
                this.bankName = value;
            }
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public void AddAccount(Account acc)
        {
            this.accounts.Add(acc);
        }

        public override string ToString()
        {
            return string.Format("Bank: \"{0}\"\n\rNumber of accounts: {1}", this.BankName, this.accounts.Count);
        }
    }
}
