using Gharxp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gharxp.Repository.Interface
{
    public interface UserRepoInterface
    {
        bool Add(User Usr);

        bool Update(User user);

        IEnumerable<User> GetAll();
    }
}
