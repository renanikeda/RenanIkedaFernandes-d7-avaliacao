
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using RenanIkedaFernandes_d7_avaliacao.Model;

namespace RenanIkedaFernandes_d7_avaliacao.Repository;
public class AppDbContext: DbContext
{
    public DbSet<User>? Users { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        CreatePath($"DB");
        Database.EnsureCreated();
    }
    public static void CreatePath(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "admin@email.com",
                Password = "admin123"
            }
        );
    }
}

