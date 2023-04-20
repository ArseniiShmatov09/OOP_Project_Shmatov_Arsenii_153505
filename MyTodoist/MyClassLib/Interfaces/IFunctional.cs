
namespace MyClassLib.Interfaces
{
    public interface IFunctional<T>
    {
        void Add(string name, string description);
        void Remove(T task);
        void Change(T task, string newName, string newDescription);
        T Find(string name);
        List<T> GetList();
    }
}
