using System.ComponentModel.DataAnnotations;

// To post, create a thread with the Id 0.
// To update, select a thread with the Id of the thread which you wanna change, minimum the Id 1.

// The categories can be:
// 1: question should be accompanied by a question mark image.
// 2: suggestion should be accompanied by a loudspeaker image.
// 3: clarification should be accompanied by a pencil image.

namespace ForumBackend.Models
{
    public class Thread
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Category { get; set; }
        public string? Body { get; set; }
        public int IdUser { get; set; }

    }
}
