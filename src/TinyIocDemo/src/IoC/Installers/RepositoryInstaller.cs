using TinyIoC;
using TinyIocDemo.Model;
using TinyIocDemo.Repository;

namespace TinyIocDemo.IoC.Installers
{
    public class RepositoryInstaller : IContainerInstaller
    {
        public void Install()
        {
            TinyIoCContainer.Current.Register<IRepository<User>, UserRepository>();
        }
    }
}