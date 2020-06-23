using Singleton.RegsitryOfSingletons;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                SingletonClass.Instance.Show();
            }

            //SingletonRegistry
            var o1 = SingletonRegistry.GetInstance<Class1>();
            var o2 = new Class1();
            var o4 = SingletonRegistry.GetInstance<Class2>();
            var o3 = SingletonRegistry.GetInstance<Class1>();


            Console.WriteLine(object.ReferenceEquals(o1, o2));
            Console.WriteLine(object.ReferenceEquals(o1, o3));
            Console.WriteLine(object.ReferenceEquals(o3, o4));


            Console.ReadLine();
            
        }
    }
}
