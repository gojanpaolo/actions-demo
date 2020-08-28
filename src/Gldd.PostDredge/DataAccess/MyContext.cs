using Microsoft.EntityFrameworkCore;

namespace Gldd.PostDredge.DataAccess
{
    public sealed class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Foo> Foo { get; set; }
    }
}
