using DesingPattern.FactoryMethod;
using System;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new StoreSaleFactory(10);

            ISale sale1 = factory.GetSale();
            sale1.Sell(15); 
        }
    }
}
