namespace _02.BankАccounts
{
    using System;

    public class Customers
    {
        private string nameOfCustomer;

        public Customers(string nameOfCustumer) 
        {
            this.NameOfCustomer = nameOfCustumer;
        }

        public string NameOfCustomer
        {
            get
            {
                return this.nameOfCustomer;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the customer cannot be empty!");
                }
                this.nameOfCustomer = value;
            }
        }
    }
}
