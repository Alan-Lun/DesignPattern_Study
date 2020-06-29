using FactoryMethod.AbstractFactorySample;
using FactoryMethod.FactoryMethodWithAdapterSample;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory
            var a = (new AbstractFactorySample.FactoryA()).CreateInstance();
            var b = (new AbstractFactorySample.FactoryB()).CreateInstance();
            a.Execute();
            b.Execute();
            

            //Factory Method for Adapter
            var c = new FactoryMethodWithAdapterSample.FactoryA().GetInstance();
            var d = new FactoryMethodWithAdapterSample.FactoryB().GetInstance();
            c.Request();
            d.Request();

            //SimpleFactorySample IfElse Sample
            var e = SimpleFactorySample.IfElseSample.FactoryA.GetInstance(SimpleFactorySample.IfElseSample.ProductType.ProductA);
            var f = SimpleFactorySample.IfElseSample.FactoryA.GetInstance(SimpleFactorySample.IfElseSample.ProductType.ProductB);
            e.Request();
            f.Request();

            //SimpleFactorySample Attribute Sample
            var g = SimpleFactorySample.AttributeSample.FactoryA.GetInstance(SimpleFactorySample.AttributeSample.ProductTypeEnum.ProductEnumA);
            var h = SimpleFactorySample.AttributeSample.FactoryA.GetInstance(SimpleFactorySample.AttributeSample.ProductTypeEnum.ProductEnumB);
            g.Request();
            h.Request();

            Console.Read();
        }
    }
}
