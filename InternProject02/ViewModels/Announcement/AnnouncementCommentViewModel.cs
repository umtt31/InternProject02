using InternProject02.Models.Announcement;

namespace InternProject02.ViewModels.Announcement
{
    public class AnnouncementCommentViewModel
    {
        public int Id { get; set; }

        public string? AnnouncementCommentName { get; set; }

        public DateTime AnnouncementCommentCreateDate { get; set; }

        public string? AnnouncementCommentBody { get; set; }

        public AnnouncementModel? AnnouncementModel { get; set; }

        public int AnnouncementId { get; set; }
    }
}
