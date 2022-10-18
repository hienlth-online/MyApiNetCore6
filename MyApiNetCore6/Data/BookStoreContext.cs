using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApiNetCore6.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt): base(opt)
        {

        }

        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
