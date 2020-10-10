using Company;
using Company.Payments;
using Company.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CompanyTest
{
    public class PhysicalProductTest
    {
        [Fact]
        public void Test_MembershipUpgradePayment()
        {
            IPayment payment = new PhysicalProductPayment();
            IProduct product = new PhysicalProduct(payment);

            IOrderProcessor processor = new OrderProcessor();

            processor.ProcessOrder(product);
            Assert.Equal("Generate a packing slip for shipping", product.Status);
        }
    }
}
