

using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage ="Title is a required field.")]
        [MinLength(2, ErrorMessage ="Title must consist of at least 2 character")]
        [MaxLength(50, ErrorMessage = "Title must consist of at max 50 character")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Price is a required field.")]
        [Range(10, 1000)]
        public decimal Price { get; set; }

    }
}
