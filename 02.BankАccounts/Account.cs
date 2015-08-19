namespace _02.BankАccounts
{
    using System;

    public abstract class Account : IDepositable
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customers customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public Customers Customer
        {
            get 
            { 
                return this.customer; 
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get 
            { 
                return this.balance; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance must be zero or positive.");
                }
                this.balance = value; 
            }
        }

        public decimal InterestRate
        {
            get 
            { 
                return this.interestRate; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate must be zero or positive.");
                }
                this.interestRate = value; 
            }
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            
            decimal interestAmount = this.interestRate * months;
            return interestAmount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Your deposit must be positive.");
            }

            this.Balance += amount;
        }

        public override string ToString()
        {
            return string.Format("Owner: {0}\nAccount type: {1}\nBalance: {2} BGN\nInterestAmount: {3}",
                this.Customer.NameOfCustomer, this.GetType().Name, this.Balance, this.CalculateInterestAmount(8));
        }
    }
}
