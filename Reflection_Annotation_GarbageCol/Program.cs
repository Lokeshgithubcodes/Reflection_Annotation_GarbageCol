using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Annotation_GarbageCol
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ---------Garbage Collection
            //for (int i = 0; i < 10000; i++)
            //{
            //    var obj = new GarbageCol(i);
            //}

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Console.WriteLine("Garbage collection Successfull");
            //Console.ReadLine();

            //---------- Reflection
            //// Get the type information for MyClass
            //Type myClassType = typeof(MyClass);

            //// Create an instance of MyClass
            //object myClassInstance = Activator.CreateInstance(myClassType);

            //// Access and set the value of a property dynamically
            //PropertyInfo propertyInfo = myClassType.GetProperty("MyProperty");
            //propertyInfo.SetValue(myClassInstance, 42);

            //// Invoke a method dynamically
            //MethodInfo methodInfo = myClassType.GetMethod("MyMethod");
            //methodInfo.Invoke(myClassInstance, null);

            //// Access the value of the property dynamically
            //int propertyValue = (int)propertyInfo.GetValue(myClassInstance);
            //Console.WriteLine($"Value of MyProperty: {propertyValue}");

            //--------Annotations

            // Use reflection to inspect attributes on the class and method
            Type myClassType = typeof(MyyClass);
            MyCustomAttribute classAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(myClassType, typeof(MyCustomAttribute));

            MethodInfo methodInfo = myClassType.GetMethod("MyMethod");
            MyCustomAttribute methodAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(MyCustomAttribute));

            // Print attribute information
            Console.WriteLine("Class Attribute Description: " + classAttribute.Description);
            Console.WriteLine("Method Attribute Description: " + methodAttribute.Description);


        }
    }
}
