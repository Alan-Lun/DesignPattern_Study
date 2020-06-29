using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    public class ProductAttribute:Attribute
    {
        internal Type InstanceType
        {
            get;private set;
        }
        internal ProductAttribute(Type type)
        {
            InstanceType = type;
        }
    }
}
