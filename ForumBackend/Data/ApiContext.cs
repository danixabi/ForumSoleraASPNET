using Microsoft.EntityFrameworkCore;
using ForumBackend.Models;
using Thread = ForumBackend.Models.Thread; // To get rid of an ambiguity due to a reserved word.

namespace ForumBackend.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) :base(options)
        {

        }
    }
}
