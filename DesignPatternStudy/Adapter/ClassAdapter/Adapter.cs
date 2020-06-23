using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.ClassAdapter
{
    public class Adapter:Adaptee,ITarget
    {
        //介面做介接
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
