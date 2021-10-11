using System;
using System.Threading.Tasks;

namespace StabObject
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string userName = "Ив";
            UserRepository userRepository = new("Host=localhost;Username=postgres;Password=Ipk07;Database=testdb");
            UserExplorer userExplorer = new(userRepository);

            User user = await userExplorer.FindByNameAsync(userName);
            if (user != null)
            {
                Console.WriteLine($"User {user.Name} is found!");
            }
            else
            {
                Console.WriteLine($"User {userName} isn't found!");
            }
        }
    }
}