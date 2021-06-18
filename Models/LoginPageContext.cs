using Microsoft.EntityFrameworkCore;

namespace LoginPage.Models
{
    public class LoginPageContext : DbContext
    {
        public LoginPageContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }

    }
}