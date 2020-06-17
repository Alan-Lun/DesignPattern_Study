using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new Test()
            {
                Title = "123",
                Content = "data"
            };
            var json = MyJsonConverter.Serialize<Test>(testData);
            Console.WriteLine("Object to Json");
            Console.WriteLine(json);
            var testModel = MyJsonConverter.Deserialize<Test>(json);
            Console.WriteLine("Json to Object");
            Console.WriteLine(testModel.Content + testModel.Title);
            Console.ReadLine();

        }
    }

    public class Test
    {
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
