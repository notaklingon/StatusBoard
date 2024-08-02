using Microsoft.EntityFrameworkCore;

namespace StatusBoard.Models
{
    public class DbContextTestSetup
    {
        public MockContext GetSqliteInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<MockContext> ()
            .UseSqlite("DataSource=:memory:")
            .Options;

            var context = new MockContext(options);
            context.Database.OpenConnection();
            context.Database.EnsureCreated();
            return context;
        }
    }
}
