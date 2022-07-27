using Microsoft.EntityFrameworkCore; 

namespace Stock.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        } 
    }
}
