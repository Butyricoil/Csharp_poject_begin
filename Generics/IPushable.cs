namespace csharp_project_begin.Generics;

public interface IPushable<in /*in Добаили */T> where T : Animal// стал контр вариантныйм
{
    public void Push(T obj);
}