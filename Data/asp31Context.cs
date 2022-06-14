using Microsoft.EntityFrameworkCore;

namespace asp31.Data
{
    public class asp31Context : DbContext
    {
        public asp31Context(DbContextOptions<asp31Context> options)
            : base(options)
        {
        }

        public DbSet<asp31.Models.Employee> Employee { get; set; }
    }
}
