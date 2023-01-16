using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class FavoriteRepository : Repository<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
