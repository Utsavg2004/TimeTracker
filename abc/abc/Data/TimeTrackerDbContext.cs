using abc.Models;
using Microsoft.EntityFrameworkCore;
namespace abc.Data
{
    public class TimeTrackerDbContext: DbContext
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options)
        {

        }

        public DbSet<TimeEntry> TimeEntries { get; set; }
    }

    
}
