using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTracking
{
    class Customer
    {
        public string CitizenshipNumber { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }//Cart Numarası
        public DateTime ExpireDate { get; set; }//Son Kullanma Tarihi
        public short Cvc { get; set; }//CVC, 3 hanelidir.

    }
}
