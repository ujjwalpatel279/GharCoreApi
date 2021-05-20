using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gharxp.Repository.Interface
{
    public interface IRepo<T>
    {
        Task<List<T>> GetAll(string procedure, object parameters);

        Task<T> Get(string procedure, object parameters);

        Task<List<T>> Find(string procedure, object parameters = null);

        Task<T> Save(string procedure, T entity);

        Task<object> Save(string procedure, object parameters);
    }
}
