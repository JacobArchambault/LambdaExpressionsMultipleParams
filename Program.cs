using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((string msg, int result) =>
            { Console.WriteLine("Message: {0}, Result: {1}", msg, result); }); 

            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
