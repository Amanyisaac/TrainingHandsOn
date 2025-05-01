using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Payment
    {
        public int Id { get; set; }
        public  String PaymentType { get; set; }
        public String PaymentStatus { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Customer Payer { get; set; }
        public Customer Payee { get; set; }
         public Payment(int id ,String paymenttype, String paymentstatus, double amount, DateTime paymentDate,Customer payer,Customer payee)
        {
            Id = id;
            PaymentType = paymenttype;
            PaymentStatus = paymentstatus;
            Amount = amount;
            PaymentDate = paymentDate;
            Payer = payer;
            Payee = payee;
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

