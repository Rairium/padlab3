using System.ComponentModel.DataAnnotations;

namespace padlab.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public string Author { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
