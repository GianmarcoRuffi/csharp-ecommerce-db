using Microsoft.EntityFrameworkCore;

public class EcommerceContext : DbContext
{
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<Products> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True;Encrypt=false\r\n");
    }
}