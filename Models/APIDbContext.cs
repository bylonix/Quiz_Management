using Microsoft.EntityFrameworkCore;

namespace Quiz_Game.Models {
    public class APIDbContext : DbContext{

        public APIDbContext(DbContextOptions options) : base(options) {
        
        }

        public DbSet<Quiz> Quizzes { get; set; }

    }
}
