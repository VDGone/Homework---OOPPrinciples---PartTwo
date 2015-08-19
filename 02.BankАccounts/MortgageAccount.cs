namespace _02.BankАccounts
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customers customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return (base.CalculateInterestAmount(months) / 2);
                }
                else
                {
                    return base.CalculateInterestAmount(months - 12);
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 6);
                }
            }
        }
    }
}
