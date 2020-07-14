using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class AbstractClass:IAbstractClass
    {
        public void TemplateMethod()
        {
            //放音樂
            PremitiveOperataion1();
            //展示手機
            PremitiveOperataion2();
            StarUp();
        }

        protected abstract void PremitiveOperataion1();
        protected abstract void PremitiveOperataion2();

        protected virtual void StarUp()
        {
            Console.WriteLine("老闆上台");
        }

    }
}
