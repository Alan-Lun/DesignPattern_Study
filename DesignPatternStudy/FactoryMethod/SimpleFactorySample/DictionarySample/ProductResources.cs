using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.DictionarySample
{
    /// <summary>
    /// 建立資源搜尋器
    /// </summary>
    internal class ProductResources
    {
        private static Dictionary<ProductTypeEnum, Type> _resources;
        static ProductResources()
        {
            _resources = new Dictionary<ProductTypeEnum, Type>();
            _resources[ProductTypeEnum.ProductEnumA] = typeof(ProductA);
            _resources[ProductTypeEnum.ProductEnumB] = typeof(ProductB);
            //多的時候再增加
        }

        internal static Type GetInstanceType(ProductTypeEnum type)
        {
            if (_resources.ContainsKey(type))
            {
                return _resources[type];
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
