using Microsoft.EntityFrameworkCore;

namespace AuthApi.Model
{
    public class AuthDbContext: DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options) { }
        public DbSet<User> Users { get; set; }
    }


}
