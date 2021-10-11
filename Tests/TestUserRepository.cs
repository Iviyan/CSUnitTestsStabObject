using System.Collections.Generic;
using System.Threading.Tasks;

namespace StabObject
{
    public class TestUserRepository : IRepository<User>
    {
        public Task<List<User>> GetAsync()
        {
            return Task.FromResult<List<User>>(new()
            {
                new() { Id = 1, Name = "Иван" },
                new() { Id = 2, Name = "Пётр" },
                new() { Id = 3, Name = "Сергей" },
            });
        }
    }
}