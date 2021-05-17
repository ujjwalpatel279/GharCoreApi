using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gharxp.Entities;
using Gharxp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gharxp.Service.Interface;


namespace Gharxp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IuserInterface _userservice;

        public  UserController(IuserInterface user)
        {
            this._userservice = user;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userservice.GetAll();
        }

        [HttpPost]
        public void Post(User user)
        {
            if (ModelState.IsValid)
                _userservice.AddUser(user);
        }
           
    }
}