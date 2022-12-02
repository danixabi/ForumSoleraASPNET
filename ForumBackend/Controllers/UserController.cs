using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ForumBackend.Models;
using ForumBackend.Data;

namespace ForumBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApiContext _context;

        public ApiContext? Context { get; }

        public UserController(ApiContext context)
        {
            _context = context;
        }


        // Create & update:
        // To post, create an user with the Id 0.
        // To update, select an user with the Id of the user whom you wanna change, minimum the Id 1.
        [HttpPost]
        public JsonResult CreateEdit(User user)
        {
            if(user.Id == 0)
            {
                _context.Users.Add(user);
            }
            else
            {
                var userInDb = _context.Users.Find(user.Id);

                if(userInDb == null)
                    return new JsonResult(NotFound());
                

                userInDb = user;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(user));
        }

        // Get by id:
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Get all:
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Users.ToList();
            return new JsonResult(Ok(result));
        }

        // Delete:
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Users.Remove(result);
            _context.SaveChanges();
            return new JsonResult(NoContent());
        }
    }
}
