using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class MyJsonConverter
    {
        public static T Deserialize<T>(string json)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }

        public static string Serialize<T>(T source)
        {
            return System.Text.Json.JsonSerializer.Serialize<T>(source);
        }
    }
}
