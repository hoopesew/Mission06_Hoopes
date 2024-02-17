using System.ComponentModel.DataAnnotations;

namespace Mission06_Hoopes.Models
{
    public class MovieSubmission
    {
        [Key]
        public int MovieID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        // Changed to nullable bool to allow null values
        public bool? Edited { get; set; }

        // Already nullable since it's a reference type
        public string Lent_To { get; set; }

        // Already nullable and can have up to 25 characters if not null
        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string Notes { get; set; }
    }
}