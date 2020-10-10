using Company.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Products
{
    public class SkiVideoProduct : IProduct
    {
        public IPayment PaymentProcessor { get; set; }
        public string Status { get; set; }
        public SkiVideoProduct(IPayment paymentProcessor)
        {
            this.PaymentProcessor = paymentProcessor;
        }
    }


}
