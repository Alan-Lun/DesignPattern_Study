using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryMethodWithAdapterSample
{
    public interface IFactory
    {
        ITarget GetInstance();
    }
}
