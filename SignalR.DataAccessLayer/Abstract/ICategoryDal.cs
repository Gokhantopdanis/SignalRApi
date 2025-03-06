using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();

        int ActivateCategoryCount();

        int DeactivateCategoryCount();
    }
}
