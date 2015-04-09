using TinyIocDemo.Model;
using TinyIocDemo.Repository;
using TinyIocDemo.Security;

namespace TinyIocDemo.Providers
{
    public interface IAuthenticationProvider
    {
        void Login(string username, string password);
    }

    public class AuthenticationProvider : IAuthenticationProvider
    {
        private readonly IAuthentication _authentication;
        private readonly IRepository<User> _useRepository;

        public AuthenticationProvider(IAuthentication authentication, IRepository<User> useRepository)
        {
            _authentication = authentication;
            _useRepository = useRepository;
        }

        public void Login(string username, string password)
        {
            var isAuthenticated = _authentication.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                var user = _useRepository.Get(username);

                // do stuff...
            }
        } 
    }
}