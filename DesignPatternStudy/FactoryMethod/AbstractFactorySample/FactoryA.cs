using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactorySample
{
    public class FactoryA : AbstractFactory
    {
        public override AbstractProduct CreateInstance()
        {
            return new ProductA();
        }
    }
}
