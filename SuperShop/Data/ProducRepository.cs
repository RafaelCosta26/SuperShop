using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class ProducRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProducRepository(DataContext context) : base(context)
        {
        }
    }
}
