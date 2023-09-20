using SampleBlog.Model;

namespace SampleBlog.Repository.IRepository
{
    public interface ICategoryRepository
    {
        bool CategoryExistByName(string Name);
        IEnumerable<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
