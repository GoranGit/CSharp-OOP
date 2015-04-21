namespace Bank
{
    using System;
    using Accounts;
    using Customers;
    using System.Collections.Generic;
    public class Bank
    {
        public static void CreateBank()
        {
            ICustomer goso = new Individual("Goso");
            Deposit deposit = new Deposit(goso, 4544.433M, 30M);
            Loan loan = new Loan(goso, 5427.43M, 35.4M);

            ICustomer peso = new Company("Peso d.o.o");
            Deposit dep = new Deposit(peso, 56389.432m, 80m);
            Mortgage mortgage = new Mortgage(peso, 5637.453m, 27m);

            List<ICustomer> customers = new List<ICustomer>() { goso, peso };

            List<Account> accounts = new List<Account>() { deposit, loan, dep, mortgage };
            PrintInterestAmountFor(3, accounts);
            PrintInterestAmountFor(6, accounts);
            PrintInterestAmountFor(9, accounts);
            PrintInterestAmountFor(12, accounts);
            PrintInterestAmountFor(24, accounts);
        }
        public static void PrintInterestAmountFor(int months, List<Account> accounts)
        {
            Console.WriteLine();
            Console.WriteLine("CalculateInterestAmount for all acounts for {0} months!", months);
            accounts.ForEach(x => Console.WriteLine(x.Customer.Name + " " + x.GetType().Name + " " + x.CalculateInterestAmount(months) + "lv"));
        }
    }
}
