using AutoMapper;
using InternProject02.Models.Announcement;
using InternProject02.ViewModels.Announcement;

namespace InternProject02.Utils
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AnnouncementModel, AnnouncementViewModel>().ReverseMap();
            CreateMap<AnnouncementCommentModel, AnnouncementCommentViewModel>().ReverseMap();
        }
    }
}
