using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.RegsitryOfSingletons
{
    public class SingletonRegistry
    {
        private static Dictionary<string, object> registry = new Dictionary<string, object>();

        public static T GetInstance<T>() where T : class, new()
        {
            Type type = typeof(T);
            string key = type.Name;
            if (registry.ContainsKey(key) == false)
            {
                registry[key] = new T();
            }
            return (T)registry[key];
        }
    }
}
