namespace Bank.Accounts
{
    using System;
    using Customers;
    public abstract class Account
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;
        public Account(ICustomer customer,decimal balance,decimal interestRate)
        {
            this.Balance = balance;
            this.Customer = customer;
            this.InterestRate = interestRate;
        }
        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value==null)

                    throw new ArgumentException("Customer can't be null!");
                else
                    this.customer = value;
            }
        }
        public decimal Balance 
        {
            get
            {
                return this.balance;
            }
            protected set 
            {
                if (value < 0)
                    throw new ArgumentException("Balance can't be  negative!");
                else
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
                    throw new ArgumentOutOfRangeException("Interest rate can't be  negative!");
                else
                    this.interestRate = value;
            }
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            return months * this.InterestRate;
        }
        
    }
}
