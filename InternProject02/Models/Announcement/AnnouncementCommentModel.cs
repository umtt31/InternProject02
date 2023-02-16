namespace InternProject02.Models.Announcement
{
    public class AnnouncementCommentModel
    {
        public int Id { get; set; }

        public string? AnnouncementCommentName { get; set; }

        public DateTime AnnouncementCommentCreateDate { get; set; }

        public string? AnnouncementCommentBody { get; set; }

        public AnnouncementModel AnnouncementModel { get; set; }
    }
}
