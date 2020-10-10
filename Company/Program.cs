using Company.Payments;
using Company.Products;
using System;

namespace Company
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOrderProcessor processor = new OrderProcessor();
            IProduct product = null;

            product = new Book(new BookPayment());// This can be injected too
            processor.ProcessOrder(product);

            product = new Membership(new MembershipUpgradePayment());
            processor.ProcessOrder(product);

            product = new SkiVideoProduct(new SkiVideoPayment());
            processor.ProcessOrder(product);
        }
    }
}
