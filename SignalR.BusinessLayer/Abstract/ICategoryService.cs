using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public int TCategoryCount();

        int TActivateCategoryCount();

        int TDeactivateCategoryCount();
    }
}
