using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Tasking_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Task.Run(()=>Run());

            Console.ReadLine();
        }

        static async Task Run()
        {
            Console.WriteLine("In Run");
            Console.WriteLine(Task.CurrentId);
            Console.WriteLine(Thread.CurrentThread.ExecutionContext.GetHashCode());
            await Task.Delay(5000);
            Console.WriteLine(Task.CurrentId);
            Console.WriteLine(Thread.CurrentThread.ExecutionContext.GetHashCode());
            await Task.Delay(5000);
            await Run1();
        }

        static async Task Run1()
        {
            Console.WriteLine("In Run1");
            Console.WriteLine(Task.CurrentId);
            Console.WriteLine(Thread.CurrentThread.ExecutionContext.GetHashCode());
            await Task.Delay(5000);
            Console.WriteLine(Task.CurrentId);
            Console.WriteLine(Thread.CurrentThread.ExecutionContext.GetHashCode());
            await Task.Delay(5000);
        }
    }
}
