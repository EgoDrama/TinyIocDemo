using System.Threading;
using TinyIocDemo.Model;

namespace TinyIocDemo.Repository
{
    public class UserRepository : IRepository<User>
    {
        public User Get(string username)
        {
            //Thread.Sleep(5000);
            return new User { UserName = username };
        }
    }
}