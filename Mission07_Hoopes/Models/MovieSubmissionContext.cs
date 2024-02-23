using Microsoft.EntityFrameworkCore;

namespace Mission06_Hoopes.Models
{
    public class MovieSubmissionContext : DbContext
    {
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext>options): base(options) { } //constructor
        public DbSet<MovieSubmission> AddFilms { get; set; }
    }

    
}
