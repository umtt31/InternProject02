using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InternProject02.Models.Announcement;

namespace InternProject02.Models.Configuration
{

    internal class AppDbContextConfiguration : IEntityTypeConfiguration<AnnouncementCommentModel>
    {
        public void Configure(EntityTypeBuilder<AnnouncementCommentModel> builder)
        {
            builder.HasOne(x => x.AnnouncementModel).WithMany(x => x.Comments).HasForeignKey(x => x.AnnouncementId);
        }
    }
   
}
