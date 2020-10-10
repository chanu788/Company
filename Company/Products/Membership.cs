using Company.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Products
{
    public class Membership : IProduct
    {

        public IPayment PaymentProcessor { get; set; }
        public string Status { get; set; }

        public Membership(IPayment paymentProcessor)
        {
            this.PaymentProcessor = paymentProcessor;
        }
    }
}
