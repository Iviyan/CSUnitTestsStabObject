using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace StabObject
{
    public class UserRepository : IRepository<User>
    {
        private string connectionString;
        public UserRepository(string connectionString) => this.connectionString = connectionString;
        
        public async Task<List<User>> GetAsync()
        {
            await using var db = new NpgsqlConnection(connectionString);
            return (await db.QueryAsync<User>("SELECT * FROM Users")).ToList();
        }
    }
}