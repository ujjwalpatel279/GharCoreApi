using Gharxp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gharxp.Service.Interface
{
    public interface UserServiceInterface
    {
        bool AddUser(User user);

        bool UpdateUser(User user);

        Task<IEnumerable<User>> GetAll();
    }
}
