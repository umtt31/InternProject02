using InternProject02.Models.Announcement;
using Microsoft.EntityFrameworkCore;

namespace InternProject02.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<AnnouncementModel> Announcements { get; set; }

        public DbSet<AnnouncementCommentModel> AnnouncementComments { get; set; }
    }
}
