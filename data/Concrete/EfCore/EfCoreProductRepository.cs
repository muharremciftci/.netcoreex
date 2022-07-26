using data.Abstract;
using entity;

namespace data.Concrete.EfCore
{
    public class EfCoreProductRepository : IRepository<Product>
    {
        private ShopContext db = new ShopContext();
        public void Create(Product entity)
        {
            db.Products?.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}