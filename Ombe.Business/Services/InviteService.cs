using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class InviteService : BaseService, IInviteService
    {
        private readonly IInviteRepository _inviteRepository;

        public InviteService(INotifier notifier,
            IInviteRepository inviteRepository) : base(notifier)
        {
            _inviteRepository = inviteRepository;
        }

        public Task Adicionar(Invite invite)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Invite invite)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
