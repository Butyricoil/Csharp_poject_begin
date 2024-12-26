namespace csharp_project_begin.Generics;

public interface ICar <out /* добавляем оут */T> where T : Engine //теперь ковариантный
{
    T GetEngine();
}