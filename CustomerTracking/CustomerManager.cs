using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTracking
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();
        public void Add(Customer customer)
        {
            //musteriListesi.Insert(musteri.MusteriId-1,musteri);
            customerList.Insert(customer.CustomerID - 1, customer);
        }

        public void Delete(Customer customer)
        {
            //musteriListesi.Remove(musteri);
            customerList.Remove(customer);
        }

        public void List()
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine(customer.FirstName);//For not using much time I just used this simple out for 
                //simulating
            }
        }
    }
}
