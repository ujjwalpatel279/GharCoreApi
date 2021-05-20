using Gharxp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gharxp.Repository.Interface
{
    public interface UserRepoInterface
    {
        bool Add(User Usr);

        bool Update(User user);

        Task<IEnumerable<User>> GetAll();
    }
}
