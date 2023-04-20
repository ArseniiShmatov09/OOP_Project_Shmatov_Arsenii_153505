namespace MyClassLib.Interfaces
{
    public interface IFunctionalController
    {
        void Add(string name, string description);
        void Remove(string name);
        void Change(string name, string newName, string newDescription);
        public void Show();

    }
}
