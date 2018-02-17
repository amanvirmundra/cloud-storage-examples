namespace CloudStorage.Examples
{
    public interface IContainerOperations
    {
        void Create(string name);
        void Delete(string name);
    }
}
