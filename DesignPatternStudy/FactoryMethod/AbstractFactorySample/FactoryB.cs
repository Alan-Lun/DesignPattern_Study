using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactorySample
{
    public class FactoryB : AbstractFactory
    {
        public override AbstractProduct CreateInstance()
        {
            return new ProductB();
        }
    }
}
