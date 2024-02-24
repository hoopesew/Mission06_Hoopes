using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//I created a new model because I wanted to start from scratch

namespace Mission06_Hoopes.Models
{
    public class MovieSub
    {
        [Key] public int MovieId { get; set; }


        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }


        [Required(ErrorMessage = "Title is required.")]

        public string Title { get; set; }

        [Range(1889, Int32.MaxValue, ErrorMessage = "Year must be later than 1888.")]
        [Required(ErrorMessage = "Year is required.")]

        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is Required.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex is required.")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes shouldn't be longer than 25 characters.")]
        public string? Notes { get; set; }

    }
}
