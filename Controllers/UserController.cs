using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Truking.Data;
using Truking.Models;
using Truking.Models.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Truking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private TrukingDbContext trukingDb;
        private IMapper mapper;
        public UserController(TrukingDbContext trukingDb, IMapper mapper) 
        { 
            this.trukingDb = trukingDb;
            this.mapper = mapper;
        }
        [HttpGet]
        public List<UserDto> Get()
        {
            List<User> users = trukingDb.Users.ToList();
            
            return mapper.Map< List<UserDto>>(users);
        }

        [HttpGet("{id}")]
        public UserDto Get(Guid id)
        {
            User user = trukingDb.Users.Find(id);
            return mapper.Map< UserDto>(user);
        }

        [HttpPost]
        public void Post([FromBody] UserDto user)
        {
                trukingDb.Users.Add(mapper.Map<User>(user));
                trukingDb.SaveChanges();           
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] UserDto user)
        {
            User old = trukingDb.Users.Find(id);
            if (old != null)
            {
                old = mapper.Map<User>(user);
            }
            trukingDb.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            User user = trukingDb.Users.Find(id);
            if (user != null)
            {
                trukingDb.Remove(user);
            }
            trukingDb.SaveChanges();
        }
    }
}
