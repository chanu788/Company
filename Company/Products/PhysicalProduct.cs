using Company.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Products
{
    class PhysicalProduct : IProduct
    {
        public IPayment PaymentProcessor { get; set; }
        public string Status { get; set; }
        public PhysicalProduct(IPayment paymentProcessor)
        {
            this.PaymentProcessor = paymentProcessor;
        }
    }
}
