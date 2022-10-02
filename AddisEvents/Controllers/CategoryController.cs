using AddisEvents.Models;
using AddisEvents.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddisEvents.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService service)
        {
            categoryService = service;
        }
        public async Task<IActionResult> Index()
        {
            var categoryData = await categoryService.GetAllAsync();
            return View(categoryData);
        }
        public async Task<IActionResult> Details(int id)
        {
            var categoryData = await categoryService.GetByIdAsync(id);
            return View(categoryData);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await categoryService.AddAsync(category);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var data = await categoryService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (id == category.Id)
            {
                await categoryService.UpdateAsync(id, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await categoryService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var data = await categoryService.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            await categoryService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

