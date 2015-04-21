
namespace Bank.Accounts
{
    public class Deposit : Account, IWithDrawable
    {
        private ICustomer goso;
        private double p1;
        private int p2;

        public Deposit(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void WithDraw(decimal amount)
        {
            this.Balance-=amount;
        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
                return 0;
            else
                return base.CalculateInterestAmount(months);
        }
    }
}
