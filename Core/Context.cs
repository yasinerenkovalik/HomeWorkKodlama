using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=Lotus;User Id=sa;Password=YourPassword123;");
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Category> Categories { get; set; }


}