using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ProductAClass:AbstractClass
    {
        protected override void PremitiveOperataion1()
        {
            Console.WriteLine("先放音樂");
        }

        protected override void PremitiveOperataion2()
        {
            Console.WriteLine("展示手機");
        }

    }
}
