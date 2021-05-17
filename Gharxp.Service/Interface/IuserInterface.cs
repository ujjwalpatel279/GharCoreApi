using Gharxp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gharxp.Service.Interface
{
    public interface IuserInterface
    {
        bool AddUser(User user);

        IEnumerable<User> GetAll();
    }
}
