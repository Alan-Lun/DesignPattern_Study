using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonClass
    {
        private int i = 0;
        public void Show()
        {
            Console.WriteLine("Hello " + i.ToString());
            i += 1;
        }

        private static void GetSingleton()
        {
            _instance = new SingletonClass();
        }

        public void Clear()
        {
            //多執行序
            //商業應用用Radis ,資料小才適合用此模式 資料穩定性要高 才會用此模式
            _instance = null;
        }

        private static object _syncRoot = new object();
        private static SingletonClass _instance;
        public static SingletonClass Instance
        {
            get
            {
                //這兩個為Double lock
                if (_instance==null)
                {
                    //這兩個為Double lock
                    lock(_syncRoot)
                    {
                        if (_instance == null)
                        {
                            GetSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
