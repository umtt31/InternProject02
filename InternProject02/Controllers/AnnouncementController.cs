using AutoMapper;
using InternProject02.Models;
using InternProject02.Models.Announcement;
using InternProject02.Utils;
using InternProject02.ViewModels.Announcement;
using Microsoft.AspNetCore.Mvc;

namespace InternProject02.Controllers
{
    [Route("[controller]/[action]")]
    public class AnnouncementController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AnnouncementController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var announcements = _context.Announcements.ToList();

            return View(_mapper.Map<List<AnnouncementViewModel>>(announcements));
        }

        [Route("/[controller]/{id}")]
        public IActionResult Details(int id)
        {
            var announcement = _context.Announcements.Find(id);
            var announcementCommentSamePage = _mapper.Map<AnnouncementCommentSamePageViewModel>(announcement);
            announcementCommentSamePage.AnnouncementId = id;
            
            return View(announcementCommentSamePage);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AnnouncementViewModel newAnnouncement)
        {
            newAnnouncement.AnnouncementCreateDate = DateTime.Now;
            _context.Add(_mapper.Map<AnnouncementModel>(newAnnouncement));
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SaveComment(AnnouncementCommentSamePageViewModel announcementCommentSamePageViewModel)
        {
            var announcement = _context.Announcements.Find(announcementCommentSamePageViewModel.AnnouncementId);
            var comment = _mapper.Map<AnnouncementCommentModel>(announcementCommentSamePageViewModel);

            comment.AnnouncementCommentCreateDate = DateTime.Now;

            announcement.Comments.Add(comment);
            _context.AnnouncementComments.Add(comment);

            _context.SaveChanges();

            return RedirectToAction("Index", announcement.Id);
        }
    }
}
