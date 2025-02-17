using System.ComponentModel.DataAnnotations;

namespace ChatModels
{
    public class Chat
    {
        [Key]
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Message { get; set; }
        public DateTime? DateTime { get; set; } = System.DateTime.Now;
    }
}