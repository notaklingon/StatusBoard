using Microsoft.EntityFrameworkCore;

namespace StatusBoard.Models
{
    public class MockContext:DbContext
    {
        public MockContext(DbContextOptions<MockContext> options) : base(options) { }

        //public DbSet<TblSomeTable> tblSomeTable { get; set; }


    }
}
