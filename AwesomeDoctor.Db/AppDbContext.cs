using System.Reflection;
using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwesomeDoctor.Db;

public class AppDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DoctorReview> DoctorReviews { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<UserContact> UserContacts { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
