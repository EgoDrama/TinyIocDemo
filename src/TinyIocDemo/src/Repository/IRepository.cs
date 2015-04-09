namespace TinyIocDemo.Repository
{
    public interface IRepository<T>
    {
        T Get(string email);
    }
}