using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class OrderProcessor : IOrderProcessor
    {
        
        public void ProcessOrder(IProduct product)
        {
            product.PaymentProcessor.Pay(product);
        }
    }
}
