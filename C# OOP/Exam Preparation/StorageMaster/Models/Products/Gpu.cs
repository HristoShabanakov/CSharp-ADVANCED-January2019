
namespace StorageMaster.Models.Products
{
    public class Gpu : Product
    {
        private const double GpuWeight = 0.7;

        //Gpu – always has 0.7 weight
        public Gpu(double price)
            : base(price, GpuWeight)
        {

        }
    }
}
