using AddisEvents2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddisEvents2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Details(int Id)
        {
            var data = _service.GetById(Id);
            if (data == null) return View("Error");
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _service.Add(category);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("Error");
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category category)
        {
            _service.Update(id, category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return View("Error");
            return View(data);
        }

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
