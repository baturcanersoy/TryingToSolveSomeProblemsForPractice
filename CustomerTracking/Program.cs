using System;

namespace CustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard1 = new CreditCard();
            creditCard1.CitizenshipNumber = "11111111111";
            creditCard1.CustomerID = 1;
            creditCard1.FirstName = "Ali";
            creditCard1.LastName = "Demir";
            
            CreditCard creditCard2 = new CreditCard();
            creditCard2.CitizenshipNumber = "22222222222";
            creditCard2.CustomerID = 2;
            creditCard2.FirstName = "Ceylan";
            creditCard2.LastName = "Pınar";
            

            CreditCard creditCard3 = new CreditCard();
            creditCard3.CitizenshipNumber = "33333333333";
            creditCard3.CustomerID = 3;
            creditCard3.FirstName = "Rıza";
            creditCard3.LastName = "Mert";
            

            BankCard bankCard1 = new BankCard();
            bankCard1.CitizenshipNumber = "33333333333";
            bankCard1.CustomerID = 3;
            bankCard1.FirstName = "Rıza";
            bankCard1.LastName = "Mert";
            bankCard1.Balance = 100245;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(creditCard1);
            customerManager.Add(creditCard2);
            customerManager.Add(creditCard3);
            customerManager.Add(bankCard1);
            customerManager.List();


            

            
        }
    }
}
