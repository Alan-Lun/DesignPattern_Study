using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactorySample
{
    internal class ProductB : AbstractProduct
    {
        public override void Execute()
        {
            Console.WriteLine("ProductB");
        }
    }
}
