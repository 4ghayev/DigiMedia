using Microsoft.EntityFrameworkCore;

namespace DigiMedia.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

   
    }
}
