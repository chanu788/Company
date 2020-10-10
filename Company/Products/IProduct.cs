using Company.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Products
{
    public interface IProduct
    {
        IPayment PaymentProcessor { get; set; }
        string Status { get; set; }
    }
}
