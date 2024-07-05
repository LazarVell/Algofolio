using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage ="Tittle must be at least 5 characters long.")]
        [MaxLength(240, ErrorMessage ="Tittle cannot be over 240 characters.")]
        public string Title { get; set; } = string.Empty;

        [MinLength(5, ErrorMessage ="Content must be at least 5 characters long.")]
        [MaxLength(240, ErrorMessage ="Content cannot be over 240 characters.")]
        public string Content { get; set; } = string.Empty;

    }
}