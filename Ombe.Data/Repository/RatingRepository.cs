using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class RatingRepository : Repository<Rating>
    {
        public RatingRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
