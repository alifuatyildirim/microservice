using Microsoft.EntityFrameworkCore; 

namespace Payment.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        } 
    }
}
