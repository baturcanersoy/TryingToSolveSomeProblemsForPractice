using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTracking
{
    class CreditCard:Customer
    {
        
        public DateTime CutOffDate { get; set; }//Hesap Kesim Tarihi
        public DateTime FinalPaymentDate { get; set; }//Son Odeme Tarihi
        public Decimal TotalLimit { get; set; }//Toplam Limit
        public Decimal UsableLimit { get; set; }//Kullanılabilir Limit
        public Decimal RemainingDebt { get; set; }//Kalan Borç
        public Decimal MinPaymentAmount { get; set; }//Min Odeme Tutarı

    }
}
