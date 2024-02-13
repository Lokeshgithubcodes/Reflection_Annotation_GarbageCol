using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Annotation_GarbageCol
{
    public class MyCustomAttribute:Attribute
    {
        public string Description { get; }

        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    // Apply the custom attribute to a class and a method
    [MyCustom("This is a class with a custom attribute.")]
    public class MyyClass
    {
        [MyCustom("This is a method with a custom attribute.")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }
}
