using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class MembershipOrUpgradePayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status = ("e-mail the owner and inform them of the activation/upgrade.");
        }
    }
}
