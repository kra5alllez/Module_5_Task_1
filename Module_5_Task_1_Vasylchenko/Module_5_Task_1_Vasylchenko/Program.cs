using System;

namespace Module_5_Task_1_Vasylchenko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var run = new Starter();
            run.Run().GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
