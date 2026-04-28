using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface ICompareRepository
    {
        void AddItemToCompare(Product product);
        Compare GetCompare();
        void RemoveCompare();
        void RemoveItemFromCompare(Product product);
    }
}