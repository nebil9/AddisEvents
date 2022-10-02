using AddisEvents.Data;
using AddisEvents.Models.Base;
namespace AddisEvents.Models.Services
{
    public class CategoryService:EntityBaseRepository<Category>, ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
