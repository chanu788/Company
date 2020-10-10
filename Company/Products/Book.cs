using Company.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Products
{
    public class Book : IProduct
    {
        public IPayment PaymentProcessor { get; set; }
        public string Status { get; set; }
        public Book(IPayment paymentProcessor)
        {
            this.PaymentProcessor = paymentProcessor;
        }

    }
}
