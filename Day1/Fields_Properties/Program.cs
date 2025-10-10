using System.Security.Cryptography;

namespace Fields_Properties
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ////Console.WriteLine("Hello, World!");
            //Class1 c1 = new Class1();
            //c1.seti(100);
            //Console.WriteLine(c1.geti());

            //Class1 c2 = new Class1();
            //c2.seti(200);
            //Console.WriteLine();
            //Class1 c3= new Class1();
            //c3.seti(200);
            //Console.WriteLine();

        }

        static void Main2(string[] args) {
            //Class2 c1=new Class2();
            //c1.I = 1020;
            //Console.WriteLine(c1.I);
        }

        static void Main(string[] args)
        {
            Class3 c3= new Class3();
            c3.Prop3 = "hiwewewdcac";
            Console.WriteLine(c3.Prop3);

       
        }
    }

    public class Class1
    {
        private int i;       //class level variable -field

        public void seti(int val)
        {

            if (val <= 100)
            {
                val = i;
                Console.WriteLine(val);
            }
            else
                Console.WriteLine("Invalid Marks");
        }

        public int geti()
        {
            return i;
        }
    }


    public class Class2
    {
        private int i;         //Field
        public int I
        {
            set
            {
                if (value <= 100)
                    i = value;
                else
                    Console.WriteLine("invalid Value");
            }

            get
            {
                return i;
            }
        }
    }

    public class Class3
    {
        private string prop1;

        public string Prop1
        {
            set {  prop1 = value; }
            get { return prop1; }
        }


        private string prop2;
        public string Prop2
        {
            set { prop2 = value; }
            get { return prop2; }
        }

        // Auto property when there is no validation 
        public string Prop3 { get; set; }
    }
}
