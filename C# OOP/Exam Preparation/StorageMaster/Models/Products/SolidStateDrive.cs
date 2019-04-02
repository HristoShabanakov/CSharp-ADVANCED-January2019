namespace StorageMaster.Models.Products
{
    public class SolidStateDrive : Product
    {
        private const double SolidStateWeight = 0.2;

        public SolidStateDrive(double price) 
            : base(price,SolidStateWeight)
        {
        }
    }
}
