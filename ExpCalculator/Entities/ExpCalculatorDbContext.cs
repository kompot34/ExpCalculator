using Microsoft.EntityFrameworkCore;

namespace ExpCalculator.Entities
{
    public class ExpCalculatorDbContext : DbContext
    {
        public ExpCalculatorDbContext(DbContextOptions<ExpCalculatorDbContext> options) : base(options) { }
        public DbSet<BankAcc> bankAccs { get; set; }
        public DbSet<Currency> currencys { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Operation> operations { get; set; }
        public DbSet<Type> types { get; set; }
        public DbSet<User> users { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql();

    }
}
