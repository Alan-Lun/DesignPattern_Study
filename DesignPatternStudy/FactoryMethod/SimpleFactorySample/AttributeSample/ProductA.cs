using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    public class ProductA : ITarget
    {
        public void Request()
        {
            Console.WriteLine("SimpleFactorySample Attribute ProductA");
        }
    }
}
