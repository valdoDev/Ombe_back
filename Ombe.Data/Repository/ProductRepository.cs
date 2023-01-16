using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
