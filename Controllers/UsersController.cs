using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Role_WebAPI.Models;

namespace User_Role_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            using(var _context = new UsersDBContext())
            {              
                var users =  ( from user in _context.User
                               join userrole in _context.UserRoles on user.ID equals userrole.USer_ID 
                               select user).ToList();
                return users;
           }
        }
    }
}
