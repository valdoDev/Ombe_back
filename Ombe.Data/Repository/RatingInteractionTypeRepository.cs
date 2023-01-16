using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class RatingInteractionTypeRepository : Repository<RatingInteractionType>
    {
        public RatingInteractionTypeRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
