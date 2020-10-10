using Xunit;
using Company;
using Company.Payments;
using Company.Products;

namespace CompanyTest
{

    public class MembershipTest
    {
        [Fact]
        public void Test_MembershipActivatePayment()
        {
            IPayment membershipPayment = new MembershipPayment();
            IProduct product = new Membership(membershipPayment);

            IOrderProcessor processor = new OrderProcessor();

            processor.ProcessOrder(product);
            Assert.Equal("Membership applied", product.Status);
        }

        [Fact]
        public void Test_MembershipUpgradePayment()
        {
            IPayment membershipPayment = new MembershipUpgradePayment();
            IProduct product = new Membership(membershipPayment);

            IOrderProcessor processor = new OrderProcessor();

            processor.ProcessOrder(product);
            Assert.Equal("Apply upgrade to membership", product.Status);
        }
    }
}
