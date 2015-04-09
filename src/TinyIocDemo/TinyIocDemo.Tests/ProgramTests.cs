using Moq;
using NUnit.Framework;
using TinyIoC;
using TinyIocDemo.IoC;
using TinyIocDemo.IoC.Installers;
using TinyIocDemo.Model;
using TinyIocDemo.Providers;
using TinyIocDemo.Repository;
using TinyIocDemo.Security;

namespace TinyIocDemo.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Can_run_program()
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.Register();
            
            var program = new Program();
            program.Run();
        }

        [Test]
        public void User_is_fetched_when_user_is_authenticated()
        {
            // arrange
            new AuthenticationInstaller().Install();
            var authentication = TinyIoCContainer.Current.Resolve<IAuthentication>();

            var repo = new Mock<IRepository<User>>();
            repo.Setup(x => x.Get("foo")).Returns(new User());

            var authenticationProvider = new AuthenticationProvider(authentication, repo.Object);

            // act
            authenticationProvider.Login("foo", "bar");

            // assert
            repo.Verify(x => x.Get("foo"), Times.Once);
        }
    }
}
