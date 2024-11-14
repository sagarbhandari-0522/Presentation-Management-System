using Microsoft.EntityFrameworkCore;
using Internship_Project.Models;
using Microsoft.Identity.Client;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    
}