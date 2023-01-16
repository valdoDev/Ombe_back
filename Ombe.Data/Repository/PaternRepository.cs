using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class PaternRepository : Repository<Patern>
    {
        public PaternRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
