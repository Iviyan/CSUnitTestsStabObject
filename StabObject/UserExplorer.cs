using System.Linq;
using System.Threading.Tasks;

namespace StabObject
{
    public class UserExplorer
    {
        private IRepository<User> userRepository;
        public UserExplorer(IRepository<User> userRepository) => this.userRepository = userRepository;
        public async Task<User> FindByNameAsync(string userName)
        {
            var users = await userRepository.GetAsync();
            return users.FirstOrDefault(user => user.Name.Contains(userName));
        }
    }
}