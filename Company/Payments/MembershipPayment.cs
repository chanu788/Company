using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class MembershipPayment : IPayment
    {
        public void Pay(IProduct product)
        {
            ///Logic to apply membership
            ///
            product.Status = ("Membership applied");
        }
    }
}
