
namespace Bank.Accounts
{
    using Customers;
    public class Mortgage : Account
    {
        public Mortgage(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int months)
        {
            if(this.Customer is Company)
            {
                if (months < 13)
                    return base.CalculateInterestAmount(months) / 2;
                else
                {
                   decimal first12 = base.CalculateInterestAmount(12) / 2;
                    decimal second = base.CalculateInterestAmount(months-12);
                    return first12 + second;
                }
            }
            else
            {
                if (months < 7)
                    return 0;
                else
                    return base.CalculateInterestAmount(months);
            }
        }
    }
}
