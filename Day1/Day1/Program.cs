namespace Day1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //System.Console.WriteLine("HW");

            Class1 obj = new Class1();
            obj.Display();
            obj.Display("Aryan");

            //positinal parameter: parameter based on position it takes
            Console.WriteLine(obj.Add());
            Console.WriteLine(obj.Add(10));
            Console.WriteLine(obj.Add(10, 20)); //easy way to display output
            Console.WriteLine(obj.Add(10, 20, 30));

            //named parameter:

            Console.WriteLine(obj.Add(a: 10, b: 20, c: 30));
            Console.WriteLine(obj.Add(c: 30)); /// c get default value.if we want to get c as a perticular value and other 0
            Console.WriteLine(obj.Add(10, c: 30)); // a get value of 10 and c have value of 30, b get value default 0


        }

        public class Class1
        {
            public void Display()
            {
                Console.WriteLine("Display Called");

            }
            //function overloading:- same name different parameter.
            public void Display(string s)
            {
                Console.WriteLine("Display Called" + s);

            }
            //public int Add(int a, int b)
            //{
            //    return a + b;
            //}
            //public int Add(int a, int b, int c)
            //{
            //    return a + b + c;
            //}

            //instead of function overloading we use default parameter:

            //public int Add(int a, int b, int c=0)
            //{
            //    return a + b + c;
            //}

            //default paramter:
            public int Add(int a = 0, int b = 0, int c = 0)
            {
                return a + b + c;
            }
        }
    }
}

namespace class1
{
    public class Program
    {
        public void display()
        {
            Console.WriteLine("Display Called");
        }
    } 
}

namespace n2
{
    public class Class1 { }
    public class Class2 { }

    namespace Nested
    {
        public class Class3 { }
    }

}

namespace Payroll
{
    public class Employee { }
    public class Manager { }
}

namespace CricketTeam
{
    public class Player { }
    public class Manager { }
}