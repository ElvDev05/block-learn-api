using block_learn_api.IAM.Domain.Model.Aggregates;
using block_learn_api.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace block_learn_api.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            // Enable Audit Fields Interceptors
            builder.AddCreatedUpdatedInterceptor();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);





            // IAM Context
            builder.Entity<User>().HasKey(u => u.Id);
            builder.Entity<User>().Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(u => u.Username).IsRequired();
            builder.Entity<User>().Property(u => u.PasswordHash).IsRequired();
            builder.Entity<User>().Property(u => u.Role).HasConversion<string>(); // Guardar como texto

            // Apply SnakeCase Naming Convention
            builder.UseSnakeCaseWithPluralizedTableNamingConvention();
        }
    }
}
