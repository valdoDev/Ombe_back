using Ombe.Business.Interfaces;
using Ombe.Business.Services;
using Ombe.Flow.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombe.Flow.Invite
{
    public class Main : BaseFlow
    {
        private readonly IInviteRepository _inviteRepository;

        public Main(INotifier notifier, IInviteRepository inviteRepository) : base(notifier)
        {
            _inviteRepository = inviteRepository;
        }

        

    }
}
