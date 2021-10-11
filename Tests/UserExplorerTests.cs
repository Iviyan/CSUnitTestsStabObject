using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StabObject;

namespace Tests
{
    [TestClass]
    public class UserExplorerTests
    {
        [TestMethod]
        public async Task FileManager_FindUserByPartOfName()
        {
            string userName = "Ив";
            UserExplorer userExplorer = new(new TestUserRepository());

            User user = await userExplorer.FindByNameAsync(userName);

            Assert.AreEqual(user.Name, "Иван");
        }
    }
}