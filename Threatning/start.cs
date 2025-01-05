namespace csharp_project_begin.Threatning;

using System;
using System.Threading;
using System.Threading.Tasks;

public class Start
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting async tasks...");

        // Запуск асинхронных методов
        Task task1 = PrintNumbersAsync("Task 1");
        Task task2 = PrintNumbersAsync("Task 2");

        await Task.WhenAll(task1, task2);

        Console.WriteLine("All tasks have finished.");
    }

    private static async Task PrintNumbersAsync(string taskName)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{taskName}: {i}");
            await Task.Delay(500); // Асинхронная задержка
        }
    }
}