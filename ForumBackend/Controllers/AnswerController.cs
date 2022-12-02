using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ForumBackend.Models;
using ForumBackend.Data;

namespace ForumBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly ApiContext _context;

        public AnswerController(ApiContext context)
        {
            _context = context;
        }

        // Create & update:
        // To post, create an answer with the Id 0.
        // To update, select an answer with the Id of the answer which you wanna change, minimum the Id 1.
        [HttpPost]
        public JsonResult CreateEdit(Answer answer)
        {
            if (answer.Id == 0)
            {
                _context.Answers.Add(answer);
            }
            else
            {
                var answerInDb = _context.Answers.Find(answer.Id);

                if (answerInDb == null)
                    return new JsonResult(NotFound());


                answerInDb = answer;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(answer));
        }

        // Get by id:
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var result = _context.Answers.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Get all:
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Answers.ToList();
            return new JsonResult(Ok(result));
        }

        // Delete:
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Answers.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Answers.Remove(result);
            _context.SaveChanges();
            return new JsonResult(NoContent());
        }
    }
}
