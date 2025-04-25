using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Payment
    {
        public  String PaymentType { get; set; }
        public String PaymentStatus { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(String paymenttype, String paymentstatus, double amount, DateTime paymentDate)
        {
            PaymentType = paymenttype;
            PaymentStatus = paymentstatus;
            Amount = amount;
            PaymentDate = paymentDate;
        }

        public string GetPaymentMethod(String paymentMethod)
        {
            if (paymentMethod == "CashToDelivery" || paymentMethod == "Visa")
            {
                return paymentMethod;
            }
            return "Invalid";
        }
    }
}

