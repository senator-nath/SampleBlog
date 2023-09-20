using SampleBlog.Data;
using SampleBlog.Model;
using SampleBlog.Repository.IRepository;

namespace SampleBlog.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _Db;

        public CategoryRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }

        public void Create(Category category)
        {
            _Db.Categories.Add(category);
            _Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _Db.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _Db.Categories.Remove(category);
                _Db.SaveChanges();
            }

        }

        public IEnumerable<Category> GetAll()
        {
            return _Db.Categories.ToList();

        }



        public void Update(Category category)
        {
            _Db.Categories.Update(category);
            _Db.SaveChanges();

        }

        bool ICategoryRepository.CategoryExistByName(string name)
        {
            var value = _Db.Categories.Any(category => category.Name.ToLower().Trim() == name.Trim());
            return value;
        }
    }
}
