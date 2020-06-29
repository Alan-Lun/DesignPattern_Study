using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.AttributeSample
{
    /// <summary>
    /// 取得 enum CommucationType 上的 Attribute 中的 InstanceType 屬性值
    /// </summary>
    internal class ProductTypeHelper
    {
        internal static Type GetInstanceType(ProductTypeEnum type)
        {
            FieldInfo data = typeof(ProductTypeEnum).GetField(type.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(ProductAttribute));
            ProductAttribute result = (ProductAttribute)attribute;
            return result.InstanceType;
        }
    }
}
