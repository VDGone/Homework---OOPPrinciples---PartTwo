namespace _02.BankАccounts
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customers customers, decimal balance, decimal interest)
            : base(customers, balance, interest)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 2);
                }
            }
        }
        public override string ToString()
        {
            return String.Format("LOAN - {0} - {1:C}", this.Customer.NameOfCustomer, this.Balance);
        }
    }
}
