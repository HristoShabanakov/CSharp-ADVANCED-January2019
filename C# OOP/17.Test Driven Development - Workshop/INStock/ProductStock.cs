
namespace INStock
{
    using INStock.Contracts;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ProductStock : IProductStock
    {
        private  IProduct[] products;

        private const int InitialSize = 4;

        public ProductStock()
        {
            this.products = new IProduct[InitialSize];
        }
        public int Count { get; set; }

        public int Capacity => this.products.Length;

        public IProduct this[int index]
        { get => throw new NotImplementedException();

            set
            {
                if(index > this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.products[index] = value;
            }

            }

        public void Add(IProduct product)
        {
            //CheckSize
            //Resize
            //Add +=count

            if(product == null)
            {
                throw new InvalidOperationException();
            }
            for (int i = 0; i <this.Count; i++)
            {
                if (products[i].CompareTo(product) == 0)
                {
                    //var indexOfProducts = Array.IndexOf(products, product);
                    products[i].Quantity += product.Quantity;
                    return;
                }
            }

            if (products.Length == this.Count)
            {
                this.Resize();
            }

            this.products[this.Count++] = product;
        }

        public bool Contains(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IProduct Find(int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllInRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IProduct FindByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IProduct FindMostExpensiveProduct()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(IProduct product)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void Resize()
        {
            var tempArray = new IProduct[this.Capacity * 2];

            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this.products[i];
            }
            this.products = tempArray;
        }
    }
}
