using System;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Demo demo = new Demo();

            // Compile time error 
            //demo.FullName = "Kishor Naik"; // read Only property
            Console.WriteLine(demo.FullName);
            demo.Age = 35;
            Console.WriteLine(demo.Age);

            demo.DemoMethod("Kishor","Naik");

            Console.WriteLine(demo.DemoMethodReturn("Eshaan", "Naik"));

           
        }
    }

    public class Demo
    {
        // Constructor
        public Demo() => Console.WriteLine("Constructor Call");

        // Property
        // Read Only Property
        public String FullName => "Kishor Naik";

        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }

        // Method
        public void DemoMethod(string firstName, string lastName) => Console.WriteLine($"{firstName} {lastName}");

        public String DemoMethodReturn(string firstName, string lastName) => $"{firstName} {lastName}";

    }
}
