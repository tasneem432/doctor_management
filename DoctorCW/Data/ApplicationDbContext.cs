using DoctorCW.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoctorCW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentWithDoctor> appointmentWithDoctors { get; set; }
        public DbSet<DoctorCategory> doctorCategories { get; set; }

    }
}
