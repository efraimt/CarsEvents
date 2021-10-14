using System;



namespace AnonymusMethods1
{

    public delegate void MyDelegate();
    public delegate void MyIntDelegate(int x);
    class Program
    {
        static MyDelegate myDelegate = 
            delegate ()
            {
                Console.WriteLine("Lo Chashuv!!!!");
            };


        static MyIntDelegate myIntDelegate = delegate (int x) {
            Console.WriteLine("Anonymus prints " + x);
        };

        static void Main(string[] args)
        {
            myDelegate();
            myIntDelegate(5);
            Console.WriteLine("Hello World!");
        }
    }
}
