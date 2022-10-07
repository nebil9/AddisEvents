namespace AddisEvents2.Models
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category Category);
        Category GetById(int id);
        Category Update(int id, Category @category);
        void Delete(int id);
    }
}
