using Gharxp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gharxp.Service.Interface
{
    public interface UserServiceInterface
    {
        bool AddUser(User user);

        bool UpdateUser(User user);

        IEnumerable<User> GetAll();
    }
}
