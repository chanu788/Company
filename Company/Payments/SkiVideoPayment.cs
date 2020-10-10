using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class SkiVideoPayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status = "Add a free First Aid video";
        }
    }
}
