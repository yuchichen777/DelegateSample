namespace DelegateSample
{
     internal class Program
     {
          static void Main(string[] args)
          {
               MyClass myClass = new MyClass();
               MyDelegate myDelegate = new MyDelegate(myClass.Method1);

               myDelegate += myClass.Method2;

               myDelegate("Hello, World!");
          }

          public delegate void MyDelegate(string message);

          public class MyClass
          {
               public void Method1(string message)
               {
                    Console.WriteLine($"Method1 says: {message}");
               }

               public void Method2(string message)
               {
                    Console.WriteLine($"Method2 says: {message}");
               }
          }

     }
}
