using AutoMapper;
using InternProject02.Models;
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

        public IActionResult Details(int id)
        {
            var announcement = _context.Announcements.SingleOrDefault(a => a.Id == id);

            return View(_mapper.Map<AnnouncementViewModel>(announcement));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AnnouncementViewModel newAnnouncement)
        {
            return RedirectToAction("Index");
        }
    }
}
