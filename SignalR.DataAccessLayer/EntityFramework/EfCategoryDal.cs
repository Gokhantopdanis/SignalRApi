using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActivateCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categorys.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categorys.Count();
        }

        public int DeactivateCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categorys.Where(x => x.Status == false).Count();
        }
    }
}
