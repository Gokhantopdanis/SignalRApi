using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProdcutsWithCategories();

        int ProductCount();

        int ProductCountByCategoryNameHamburger();

        int ProductCountByCategoryNameDrink();

        decimal ProductPriceAvg();

        string ProductNameByMaxPrice();

        string ProductNameByMinPrice();

        decimal ProductPriceByHamburger();

        decimal ProductPriceBySteakBurger();

        decimal TotalPriceByDrinkCategory();

        List<Product> GetLast9Products();
    }
}
