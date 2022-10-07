namespace AddisEvents2.Models
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Category Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            var result = _context.Categories.ToList();

            return result;
        }

        public Category GetById(int id)
        {
            var result = _context.Categories.Find(id);

            return result;
        }

        public Category Update(int id, Category category)
        {
            _context.Update(category);
            _context.SaveChanges();

            return category;
        }

        public void Delete(int id)
        {
            var del = _context.Categories.Find(id);
            _context.Categories.Remove(del);
            _context.SaveChanges();
        }
    }
}
