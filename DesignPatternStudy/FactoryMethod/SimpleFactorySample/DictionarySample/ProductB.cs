using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.SimpleFactorySample.DictionarySample
{
    public class ProductB : ITarget
    {
        public void Request()
        {
            Console.WriteLine("SimpleFactorySample Dictionary ProductB");
        }
    }
}
