using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.ObjectAdapter
{
    /// <summary>
    /// 這是原本的Method
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("AdapterSample Called SpecificRequest()");
        }
    }
}
