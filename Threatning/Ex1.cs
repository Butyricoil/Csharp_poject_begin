// namespace csharp_project_begin.Threatning;
//
// public class Ex1
// {
//
//     public static async Task Main(string[] args)
//     {
//         Thread thread = new Thread(PrintNumbers);
//         thread.Start();
//
//         for (int i = 0; i < 10; i++)
//         {
//             if (i % 2 != 0)
//             {
//                 Console.WriteLine($"Main thread: {i}");
//             }
//
//             Thread.Sleep(500);
//         }
//     }
//
//     static void PrintNumbers()
//     {
//         for (int i = 0; i < 10; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.WriteLine($"Secondary Thread: {i}");
//             }
//             Thread.Sleep(500);}
//         }
// }