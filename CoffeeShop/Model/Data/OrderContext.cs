using Microsoft.EntityFrameworkCore;

public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> options) : base(options){}

    public DbSet<OrderTask> OrderTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderTask>().HasKey(t => t.Id);
    }
}