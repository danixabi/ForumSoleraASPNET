using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ForumBackend.Models;
using ForumBackend.Data;
using Thread = ForumBackend.Models.Thread; // To remove ambiguity with a reserved word.

namespace ForumBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ThreadController : ControllerBase
    {
        private readonly ApiContext _context;

        public ThreadController(ApiContext context)
        {
            _context = context;
        }

        // Create & update:
        // To post, create a thread with the Id 0.
        // To update, select a thread with the Id of the thread which you wanna change, minimum the Id 1.
        [HttpPost]
        public JsonResult CreateEdit(Thread thread)
        {
            if (thread.Id == 0)
            {
                _context.Threads.Add(thread);
            }
            else
            {
                var threadInDb = _context.Threads.Find(thread.Id);

                if (threadInDb == null)
                    return new JsonResult(NotFound());


                threadInDb = thread;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(thread));
        }

        // Get by id:
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var result = _context.Threads.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Get all:
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Threads.ToList();
            return new JsonResult(Ok(result));
        }

        // Delete:
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Threads.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Threads.Remove(result);
            _context.SaveChanges();
            return new JsonResult(NoContent());
        }
    }
}
