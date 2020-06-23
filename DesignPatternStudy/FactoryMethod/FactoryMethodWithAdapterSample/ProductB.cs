using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryMethodWithAdapterSample
{
    public class ProductB : ITarget
    {
        public void Request()
        {
            Console.WriteLine("ProductBB");
        }
    }
}
