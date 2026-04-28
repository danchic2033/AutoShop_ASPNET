using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryCompareRepository : ICompareRepository
    {
        private Compare _compare;

        public void AddItemToCompare(Product product)
        {
            if (_compare == null)
            {
                _compare = new Compare();
            }
            _compare.Products.Add(product);
        }

        public void RemoveItemFromCompare(Product product)
        {
            if (_compare.Products.Contains(product))
            {
                _compare.Products.Remove(product);
            }
        }

        public Compare GetCompare()
        {
            return _compare;
        }

        public void RemoveCompare()
        {
            if (_compare.Products.Count > 0)
            {
                _compare.Products.Clear();
            }
        }
    }
}
