using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ProductBClass : AbstractClass
    {
        protected override void PremitiveOperataion1()
        {
            Console.WriteLine("先開手機B");
        }

        protected override void PremitiveOperataion2()
        {
            Console.WriteLine("然後開趴");
        }

        protected override void StarUp()
        {
            Console.WriteLine("老闆直直落");
        }
    }
}
