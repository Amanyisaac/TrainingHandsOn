
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
        public int Id { get; set; }
        public String PaymentMethod { get; set; }
        public String PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
         public Passenger Payer { get; set; }
        public Passenger Payee { get; set; }

        public Payment(int id, String paymentMethod, String paymentStatus, DateTime paymentDate, double amount ,Passenger payer, Passenger payee)
        {
            Id = id;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
            PaymentDate = paymentDate;
            Amount = amount;
             Payer = payer;
            Payee = payee;


        }
    }
    }
 