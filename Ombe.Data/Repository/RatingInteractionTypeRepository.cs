using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class RatingInteractionTypeRepository : Repository<RatingInteractionType>, IRatingInteractionTypeRepository
    {
        public RatingInteractionTypeRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
