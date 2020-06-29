using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    public class FactoryA
    {
        public static ITarget GetInstance(ProductTypeEnum type)
        {
            Type t = ProductTypeHelper.GetInstanceType(type);
            return (ITarget)Activator.CreateInstance(t);
        }
    }
}
