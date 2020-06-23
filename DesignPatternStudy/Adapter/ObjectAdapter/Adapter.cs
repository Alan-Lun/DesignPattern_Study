using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.ObjectAdapter
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter()
        {
            this._adaptee = new Adaptee();
        }

        public void Request()
        {
            this._adaptee.SpecificRequest();
        }
    }
}
