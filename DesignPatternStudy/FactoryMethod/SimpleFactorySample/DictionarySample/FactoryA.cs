using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.DictionarySample
{
    /// <summary>
    /// 運用 資源搜尋法
    /// </summary>
    public class FactoryA
    {
        public static ITarget GetInstance(ProductTypeEnum type)
        {
            var t = ProductResources.GetInstanceType(type);
            return (ITarget)Activator.CreateInstance(t);
        }
    }
}
