using Ombe.Business.Models;
using Ombe.Data.Context;

namespace Ombe.Data.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(OmbeDbContext db) : base(db)
        {
        }
    }
}
