using System;
using System.Collections.Generic;
using Gharxp.Entities;
using Gharxp.Repository.Interface;
using Gharxp.Service.Interface;


namespace Gharxp.Service
{
    public class UserManager :IuserInterface
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

        public IEnumerable<User> GetAll()
        {
            var UserDetails = _UserRepo.GetAll();
            return UserDetails;
        }
    }
}
