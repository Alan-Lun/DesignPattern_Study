using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    public enum ProductTypeEnum
    {
        [Product(typeof(ProductA))]
        ProductEnumA,
        [Product(typeof(ProductB))]
        ProductEnumB
    }
}
