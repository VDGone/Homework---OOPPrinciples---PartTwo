namespace _02.BankАccounts
{
    using System;

    public class DepositAccount : Account, IDepositable, IDrawable
    {
        public DepositAccount(Customers customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {

        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Withdrawal amount cannot excede available balance");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}
