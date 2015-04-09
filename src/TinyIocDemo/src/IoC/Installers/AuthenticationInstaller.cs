using TinyIoC;
using TinyIocDemo.Security;

namespace TinyIocDemo.IoC.Installers
{
    public class AuthenticationInstaller : IContainerInstaller
    {
        public void Install()
        {
            TinyIoCContainer.Current.Register<IAuthentication, Authentication>();
        }
    }
}