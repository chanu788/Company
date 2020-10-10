using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Payments
{
    public class BookPayment : IPayment
    {
        public void Pay(IProduct product)
        {
            product.Status= ("Create a duplicate packing slip for the royalty department");
        }
    }
}
