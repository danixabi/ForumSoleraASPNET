using System.ComponentModel.DataAnnotations;

// To post, create an user with the Id 0.
// To update, select an user with the Id of the user whom you wanna change, minimum the Id 1.

namespace ForumBackend.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
    }
}
