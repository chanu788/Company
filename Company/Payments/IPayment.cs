using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public interface IPayment
    {
         void Pay(IProduct product);
    }
}
