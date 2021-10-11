using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StabObject
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAsync();
    }
}