using Microsoft.EntityFrameworkCore;
using Sneat.Models;

namespace Sneat.Context
{
    public class MyDBContext: DbContext
    { 
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        { 
        }

        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TestModel>(tm =>
            {
                tm.HasKey(x => x.Id);

                tm.ToTable("TestModel");
  
            });
        }
    }
}
