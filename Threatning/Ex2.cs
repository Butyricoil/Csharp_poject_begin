// namespace csharp_project_begin.Threatning;
//
// public class Ex2
// {
//
//     private static int counter = 0;
//     private static readonly object locker = new object();
//
//     public static async Task Main(string[] args)
//     {
//         Thread thread1 = new Thread(Increment);
//         Thread thread2 = new Thread(Increment);
//
//         thread1.Start();
//         thread2.Start();
//
//         thread1.Join();
//         thread2.Join();
//
//         Console.WriteLine($"Final counter value: {counter}");
//     }
//
//     static void Increment()
//     {
//         for (int i = 0; i < 1000; i++)
//         {
//             lock (locker)
//             {
//                 counter++;
//             }
//         }
//     }
// }