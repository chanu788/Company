using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class MembershipUpgradePayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status = "Apply upgrade to membership";
        }
    }
}
