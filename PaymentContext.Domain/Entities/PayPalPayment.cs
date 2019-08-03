using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string lastTransactionCode,
            DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string address, string document, string payer, string email) 
            : base(paidDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            LastTransactionCode = lastTransactionCode;
        }

        public string LastTransactionCode { get; private set; }
    }
}
