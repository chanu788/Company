using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class PhysicalProductPayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status = ("Generate a packing slip for shipping");
        }
    }
}
