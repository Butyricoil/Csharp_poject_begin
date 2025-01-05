// namespace csharp_project_begin.Threatning
// {
//     using System.Threading.Tasks;
//     using System.Threading;
//
//     public class Ex3
//     {
//         public static async Task Main(string[] args)
//         {
//             Task task1 = Task.Run(() => PrintMessage("Task 1"));
//             Task task2 = Task.Run(() => PrintMessage("Task 2"));
//
//             await Task.WhenAll(task1, task2);
//         }
//
//         static void PrintMessage(string message)
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine($"{message}: {i}");
//                 Task.Delay(500).Wait();
//             }
//         }
//     }
// }