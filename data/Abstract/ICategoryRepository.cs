using entity;

namespace data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {

      List<Category> GetPopularCategory();

         
    }
}