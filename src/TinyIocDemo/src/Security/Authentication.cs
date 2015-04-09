
namespace TinyIocDemo.Security
{
    public interface IAuthentication
    {
        bool AuthenticateUser(string username, string password);
    }

    public class Authentication : IAuthentication
    {
        public bool AuthenticateUser(string username, string password)
        {
            return true;
        }
    }
}