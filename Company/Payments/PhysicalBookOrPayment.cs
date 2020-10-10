using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class PhysicalBookOrPayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status = ("generate a commission payment to the agent.");
        }
    }
}
