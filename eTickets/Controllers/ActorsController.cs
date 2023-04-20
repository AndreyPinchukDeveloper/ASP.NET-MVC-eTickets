using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllActors();
            return View(data);
        }

        //TODO - actors/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if (ModelState.IsValid)//if don't valid
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        //TODO - actors/Details
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _service.GetByID(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
