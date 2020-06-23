using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.IfElseSample
{
    public class ProductB : ITarget
    {
        public void Request()
        {
            Console.WriteLine("SimpleFactorySample ProductB");
        }
    }
}
