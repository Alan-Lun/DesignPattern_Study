using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    public class ProductB : ITarget
    {
        public void Request()
        {
            Console.WriteLine("SimpleFactorySample Attribute ProductB");
        }
    }
}
