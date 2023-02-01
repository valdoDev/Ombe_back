using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class RatingInteractionRepository : Repository<RatingInteraction>, IRatingInteractionRepository
    {
        public RatingInteractionRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
