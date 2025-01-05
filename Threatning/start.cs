namespace csharp_project_begin.Threatning;

using System;
using System.Threading;
using System.Threading.Tasks;

public class Start
{
    public static async Task Main(string[] args)
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main thread: {i}");
            Thread.Sleep(500);
        }
    }

    static void PrintNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(1000);
        }
    }
}