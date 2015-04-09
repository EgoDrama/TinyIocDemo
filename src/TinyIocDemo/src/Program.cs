
using TinyIoC;
using TinyIocDemo.Providers;

namespace TinyIocDemo
{
    public class Program
    {
        public void Run()
        {
            var authenticationProvider = TinyIoCContainer.Current.Resolve<IAuthenticationProvider>();

            const string username = "username";
            const string password = "password";

            authenticationProvider.Login(username, password);
        }
    }
}
