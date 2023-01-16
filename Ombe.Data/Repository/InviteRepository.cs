using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class InviteRepository : Repository<Invite>
    {
        public InviteRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
