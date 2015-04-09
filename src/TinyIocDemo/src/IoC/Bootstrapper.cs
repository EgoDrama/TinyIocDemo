using TinyIocDemo.IoC.Installers;

namespace TinyIocDemo.IoC
{
    public class Bootstrapper
    {
        public void Register()
        {
            //var container = TinyIoCContainer.Current;

            //container.Register<IAuthentication, Authentication>();
            //container.Register<IRepository<User>, UserRepository>();
            //container.Register<IAuthenticationProvider, AuthenticationProvider>();

            new AuthenticationInstaller().Install();
            new RepositoryInstaller().Install();
            new ProviderInstaller().Install();
        }
    }
}