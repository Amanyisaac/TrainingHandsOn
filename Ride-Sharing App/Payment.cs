using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Payment
    {
        public String PaymentMethod { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(String paymentMethod, double amount, DateTime paymentDate)
        {
            PaymentMethod = paymentMethod;
            Amount = amount;
            PaymentDate = paymentDate;
        }

        public string GetPaymentMethod(String paymentMethod)
        {
            if (paymentMethod == "Cash" || paymentMethod == "Visa")
            {
                return paymentMethod;
            }
            return "Invalid";
        }
    }
}

