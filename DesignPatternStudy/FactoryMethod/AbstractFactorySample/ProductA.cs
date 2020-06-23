using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactorySample
{
    internal class ProductA : AbstractProduct
    {
        public override void Execute()
        {
            Console.WriteLine("ProductA");
        }
    }
}
