// namespace csharp_project_begin.linq;
//
// using System.Linq;
//
// public class Ex1
// {
//    static void Main(string[] args)
//    {
//
//       int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
//       var evenNumbers = numbers.Where(n => n % 2 == 0);
//       Console.WriteLine(string.Join("," , evenNumbers));
//
//       var squares = numbers.Select(n => n * n);
//       Console.WriteLine(string.Join(",", squares));
//
//       var sorted = numbers.OrderByDescending(n => n);
//       Console.WriteLine(string.Join(",", sorted));
//
//       var evenSquares = numbers.Where(n => n % 2 == 0).Select(n => n * n);
//       Console.WriteLine(string.Join(",", evenSquares));
//
//       int sum = numbers.Sum();
//       Console.WriteLine(sum);
//
//       int min = numbers.Min();
//       int max = numbers.Max();
//       Console.WriteLine($"Min: {min}, Max: {max}");
//
//       double average = numbers.Average();
//       Console.WriteLine($"Average: {average:F2}");
//
//       var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
//       foreach (var group in groups)
//       {
//          Console.WriteLine($"{group.Key}: {string.Join(",", group)}");
//       }
//
//       var people = new List<Person>
//       {
//          new Person { Name = "Alice", Age = 25 },
//          new Person { Name = "Bob", Age = 30 },
//          new Person { Name = "Charlie", Age = 22 }
//       };
//
//       var sortedPeople = people.OrderBy(p => p.Age);
//       foreach (var person in sortedPeople)
//       {Console.WriteLine($"{person.Name}: {person.Age}");}
//
//
//    }
// }
//
// class Person
// {
//    public string Name { get; set; }
//    public int Age { get; set; }
// }