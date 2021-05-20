using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gharxp.Entities;
using Gharxp.Repository.Interface;
using Gharxp.Service.Interface;


namespace Gharxp.Service
{
    public class UserManager :UserServiceInterface
    {
        private UserRepoInterface _UserRepo;

        public UserManager(UserRepoInterface userrepository)
        {
            _UserRepo = userrepository;
        }


        public bool AddUser(User user)
        {
            return _UserRepo.Add(user);
        }

        public bool UpdateUser(User user)
        {
            return _UserRepo.Update(user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var UserDetails = await _UserRepo.GetAll();
            return UserDetails;
        }
    }
}
