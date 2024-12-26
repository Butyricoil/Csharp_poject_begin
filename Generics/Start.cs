namespace csharp_project_begin.Generics;

public class Start
{
    static void Main(string[] args)
    {
        List<Cat> list1 = new List<Cat>();
        IEnumerable<Cat> list2 = list1; // коваариантность

        List<object> list = new List<object>();
        List<string> str = new List<string>(); // инвариантность

        object[] objects = new string[3];
        objects[0] = "Hello"; // массивы ковариантны

        Lada priora = new Lada();
        ICar<V8Engine> vEightCar = priora;
        ICar<Engine> someCar = priora; // out добавил

        IPushable<Cat> cats = new Stack<Animal>(); // контрвариантность
        cats.Push(new Cat());
    }
}