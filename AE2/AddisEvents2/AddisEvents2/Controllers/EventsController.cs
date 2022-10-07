using AddisEvents2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AddisEvents2.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _service;

        public EventsController(IEventService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Details (int Id)
        {
            var data = _service.GetById(Id);
            if (data == null) return View("Error");
            return View(data);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Event @event)
        {
            _service.Add(@event);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var data = _service.GetById(id);
            if(data == null) return View("Error");
            return View(data);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id,Event @event)
        {
            _service.Update(id, @event);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("Error");
            return View(data);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("Error");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
