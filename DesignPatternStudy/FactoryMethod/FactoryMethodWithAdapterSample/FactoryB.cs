using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryMethodWithAdapterSample
{
    public class FactoryB : IFactory
    {
        public ITarget GetInstance()
        {
            return new ProductB();
        }
    }
}
