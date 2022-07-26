using data.Abstract;
using entity;

namespace data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : IRepository<Category>
    {
         private ShopContext db = new ShopContext();
        public void Create(Category entity)
        {
            db.Categories?.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}