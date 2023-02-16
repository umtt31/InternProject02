using InternProject02.Models.Announcement;

namespace InternProject02.ViewModels.Announcement
{
    public class AnnouncementCommentSamePageViewModel
    {
        public int Id { get; set; }

        public string? AnnouncementCommentName { get; set; }

        public DateTime AnnouncementCommentCreateDate { get; set; }

        public string? AnnouncementCommentBody { get; set; }

        public AnnouncementModel AnnouncementModel { get; set; }

        public int AnnouncementId { get; set; }

        public string? AnnouncementCreator { get; set; }

        public string? AnnouncementTitle { get; set; }

        public DateTime AnnouncementCreateDate { get; set; }

        public string? AnnouncementBody { get; set; }

        public string? AnnouncementSubject { get; set; }
    }
}
