using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryMethodWithAdapterSample
{
    public class ProductA : ITarget
    {
        public void Request()
        {
            Console.WriteLine("ProductAA");
        }
    }
}
