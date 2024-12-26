namespace csharp_project_begin.Generics;

public class Lada : ICar<V8Engine>
{
    public V8Engine GetEngine()
    {
        return new V8Engine();
    }
}