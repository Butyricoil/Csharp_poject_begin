namespace csharp_project_begin.Generics;

public class Stack <T> : IPushable<T> where T : Animal
{
    public void Push(T obj)
    {

    }
}