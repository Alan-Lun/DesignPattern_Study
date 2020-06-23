using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.ClassAdapter
{
    /// <summary>
    /// 這是原本的Method
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("ClassAdapter Called SpecificRequest()");
        }
    }
}
