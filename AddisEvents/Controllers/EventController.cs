namespace AddisEvents.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService eventService;

        public EventController(IEventService service)
        {
            eventService = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await eventService.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await eventService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Event _event)
        {
            await eventService.AddAsync(_event);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await eventService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Event product)
        {
            await eventService.UpdateAsync(id, product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await eventService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var data = await eventService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            await eventService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
