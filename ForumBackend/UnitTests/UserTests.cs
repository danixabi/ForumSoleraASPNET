using ForumBackend.Controllers;
using ForumBackend.Data;
using ForumBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace ForumBackend.UnitTests
{
    public class UserTests
    {
        /*public static DateTime V { get; private set; }
        private List<User> _users = new List<User>()
        {
            new User() { Id = 1, Name = "RandomUser", Password = "dunno", RegisteredAt = V },
            new User() { Id = 2, Name = "Moderator", Password = "top_secret", RegisteredAt = V }
        };
        public IEnumerable<User> Get() => _users;
        public User? Get(int id) => _users.FirstOrDefault(d => d.Id == id);*/

        private readonly UserController _controller;
        private readonly ApiContext _context;

        public UserTests()
        {
            _controller = new UserController(_context);
        }

        [Fact]
        public void GetAll_Ok()
        {
            // Arrange:

            // Act:
            var result = _controller.GetAll();

            // Assert:
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Quantity()
        {
            // Arrange:
            var result = (JsonResult)_controller.GetAll();

            // Act:
            var users = Assert.IsType<List<User>>(result.Value);

            // Assert:
            Assert.True(users.Count == 0); // We write 0 because the database is hardcoded and we're supposed to get 0 users.
        }

        [Fact]
        public void GetById_Ok()
        {
            // Arrange:
            int id = 1;

            // Act:
            var result = _controller.GetById(id);

            // Assert:
            var user = Assert.IsType<User>(result?.Value);
            Assert.True(user != null);
            Assert.Equal(user?.Id, id);
        }

        [Fact]
        public void GetById_NotFound()
        {
            // Arrange:
            int id = 11;

            // Act:
            var result = _controller.GetById(id);

            // Arrange:
            var user = Assert.IsType<NotFoundResult>(result);
        }

    }
}
