using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.IfElseSample
{
    public class FactoryA
    {
        public static ITarget GetInstance(ProductType type)
        {
            switch (type)
            {
                case ProductType.ProductA:
                    return new ProductA();
                case ProductType.ProductB:
                    return new ProductB();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
