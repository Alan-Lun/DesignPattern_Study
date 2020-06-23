using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.IfElseSample
{
    public class ProductA : ITarget
    {
        public void Request()
        {
            Console.WriteLine("SimpleFactorySample ProductA");
        }
    }
}
