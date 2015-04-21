using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Accounts
{
    using Customers;
    public class Loan : Account
    {
        public Loan(ICustomer customer, decimal balance, decimal interestRate):base(customer,balance,interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int months)
        {
            if(this.Customer is Individual)
            {
                int monthsForCalc = months - 3 > 0 ? months - 3 : 0;
                return monthsForCalc * this.InterestRate;
            }
            if(this.Customer is Company)
            {
                int monthsForCalc = months - 2 > 0 ? months - 2 : 0;
                return monthsForCalc * this.InterestRate;
            }
            return 0;
        }
    }
}
