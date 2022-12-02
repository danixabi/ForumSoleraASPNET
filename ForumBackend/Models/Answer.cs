using System.ComponentModel.DataAnnotations;

/*
 * Responses are similar to Threads, they both have a body message.
 * Responses are attached to a single Thread.
 * A Thread can have many Responses.
 * When you open a Thread, at first you see the the Thread content, and below all the Responses.
*/


namespace ForumBackend.Models
{
    public class Answer
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string? Body { get; set; }
        public int IdThread { get; set; }
        public int IdUser { get; set; }
    }
}
