using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryMethodWithAdapterSample
{
    public class FactoryA : IFactory
    {
        public ITarget GetInstance()
        {
            return new ProductA();
        }
    }
}
