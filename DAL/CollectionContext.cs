using Microsoft.EntityFrameworkCore;

using BOL;

namespace DAL;

public class CollectionContext:DbContext{
    public DbSet<Department> Departments{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString=@"server=localhost;port=3306;user=root;password=akash@123;database=Department";
        optionsBuilder.UseMySQL(connectionString);

    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity =>{
            entity.HasKey(e => e.id);
            entity.Property(e => e.d_no).IsRequired();
            entity.Property(e => e.d_name).IsRequired();
            entity.Property(e => e.balance).IsRequired();
        });
        modelBuilder.Entity<Department>().ToTable("departments");
    }

}
