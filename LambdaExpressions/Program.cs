using System;

namespace LambdaExpressions
{
    public delegate void MyDelegate();

    public delegate int CalculationDelegate(int a, int b);

    public delegate void SecondDelegate(int a);

    class Program
    {

        static MyDelegate myDelegate1 = delegate () { };

        static MyDelegate myDelegate = () => { Console.WriteLine("My first Lambda"); };


        ////////////////////////////////////////////////////////static CalculationDelegate add1 = delegate(int a, int b) { return a + b; };    


        static CalculationDelegate add = (int x, int y) => x + y;
        static CalculationDelegate subtract = (int x, int y) => { return x - y; };


        static SecondDelegate add2 = x => { Console.WriteLine(x + 10); };


        static void Main(string[] args)
        {
            myDelegate();
            Console.WriteLine(add(6, 10));
        }
    }
}
