using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("教學做法");
            Console.WriteLine("");

            ProductAClass c = new ProductAClass();
            c.TemplateMethod();

            Console.WriteLine("");

            ProductBClass d = new ProductBClass();
            d.TemplateMethod();

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("自己嘗試弄得Template Method");
            Console.WriteLine("");

            IAbstractClass e = new ProductAClass();
            e.TemplateMethod();

            Console.WriteLine("");

            IAbstractClass f = new ProductBClass();
            f.TemplateMethod();

            Console.WriteLine("");

            Console.Read();
        }
    }
}
