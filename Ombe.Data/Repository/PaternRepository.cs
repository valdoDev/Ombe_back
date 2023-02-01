using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class PaternRepository : Repository<Patern>, IPaternRepository
    {
        public PaternRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
