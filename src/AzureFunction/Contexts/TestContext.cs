using AzureFunction.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureFunction.Contexts
{
    public class TestContext : DbContext
    {
        public DbSet<TempObject> Objects { get; set; }

        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }
    }
}