using InternProject02.Models.Announcement;
using System.ComponentModel;

namespace InternProject02.ViewModels.Announcement
{
    public class AnnouncementViewModel
    {
        public int Id { get; set; }

        public string? AnnouncementCreator { get; set; }

        public string? AnnouncementTitle { get; set; }

        public DateTime AnnouncementCreateDate { get; set; }

        public string? AnnouncementBody { get; set; }

        public string? AnnouncementSubject { get; set; }

        public List<AnnouncementCommentModel> Comments { get; set; } = new List<AnnouncementCommentModel>();
    }
}
