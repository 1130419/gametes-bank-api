using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAM.GametesBank.Users.Data;
using GAM.GametesBank.Users.Models;
using GAM.GametesBank.Users.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace GAM.GametesBank.Users.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private IUsersRepository _repository;

        public UsersController(IUsersRepository context)
        {
            _repository = context;
        }
        // GET api/users
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetAllUsers();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            return await _repository.GetUser(id);
        }

        // POST api/users
        [HttpPost]
        public async Task Post([FromBody]User user)
        {
            await _repository.AddUser(user);
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public async Task<UpdateResult> Put(string id, [FromBody]User user)
        {
            throw new Exception();
            //return await _repository.UpdateUser(id, user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
