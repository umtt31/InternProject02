using InternProject02.Models.Announcement;

namespace InternProject02.ViewModels.Announcement
{
    public class AnnouncementCommentSamePageViewModel
    {
        public int AnnouncementId { get; set; }

        public int CommentId { get; set; }

        public string? CommentName { get; set; }

        public string? CommentBody { get; set; }

        public string? AnnouncementCreator { get; set; }

        public string? AnnouncementTitle { get; set; }

        public string? AnnouncementBody { get; set; }

        public string? AnnouncementSubject { get; set; }

        public List<AnnouncementCommentModel>? Comments { get; set; }

        public DateTime AnnouncementCreateDate { get; set; }
    }
}
