using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagement_Shared.Models;

namespace StudentManagement.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<SystemCode> SystemCodes { get; set; }
    public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
}