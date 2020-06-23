using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractFactorySample
{
    /// <summary>
    /// 抽象建立實體，每一個Factory有不同的實體設計
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProduct CreateInstance();
    }
}
