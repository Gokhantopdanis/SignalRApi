using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProdcutsWithCategories();

        int TProductCount();

        int TProductCountByCategoryNameDrink();

        int TProductCountByCategoryNameHamburger();

        decimal TProductPriceAvg();

        string TProductNameByMaxPrice();

        string TProductNameByMinPrice();

        decimal TProductPriceByHamburger();
    }
}
