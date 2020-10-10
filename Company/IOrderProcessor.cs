using Company.Products;

namespace Company
{
    public interface IOrderProcessor
    {
        void ProcessOrder(IProduct product);
    }
}