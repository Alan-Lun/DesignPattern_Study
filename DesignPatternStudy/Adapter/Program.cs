using AdapterSample.ClassAdapter;
using AdapterSample.ObjectAdapter;
using System;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Adapter(建議不要用)
            ClassAdapter.ITarget t = new ClassAdapter.Adapter();
            t.Request();
            

            //Object Adapter
            AdapterSample.ObjectAdapter.ITarget tt = new ObjectAdapter.Adapter();
            tt.Request();

            Console.Read();
        }
    }
}
