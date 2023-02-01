using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class InviteRepository : Repository<Invite>, IInviteRepository
    {
        public InviteRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
