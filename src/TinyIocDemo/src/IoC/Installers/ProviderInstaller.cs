using TinyIoC;
using TinyIocDemo.Providers;

namespace TinyIocDemo.IoC.Installers
{
    public class ProviderInstaller : IContainerInstaller
    {
        public void Install()
        {
            TinyIoCContainer.Current.Register<IAuthenticationProvider, AuthenticationProvider>();
        }
    }
}