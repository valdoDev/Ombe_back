using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
using System;
using System.Collections.Generic;
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

        public async Task Adicionar(Invite invite)
        {
            if (!ExecutarValidacao(new InviteValidation(), invite)) return;

            await _inviteRepository.Adicionar(invite);
        }

        public async Task Atualizar(Invite invite)
        {
            if (!ExecutarValidacao(new InviteValidation(), invite)) return;

            await _inviteRepository.Atualizar(invite);
        }

        public async Task Remover(Guid id)
        {
            await _inviteRepository.Remover(id);
        }

        public void Dispose()
        {
            _inviteRepository?.Dispose();
        }

        public async Task<Invite> getID(Guid id)
        {
            return await _inviteRepository.ObterPorId(id);
        }

        public async Task<Invite> getCodeFirst(String code)
        {
            var list = await _inviteRepository.Buscar((inv) => String.Equals(inv.Code, code, StringComparison.OrdinalIgnoreCase));
            
            if (list == null)
                return null;

            foreach (var item in list)
                if (isValid(item))
                    return item;

            return null;
        }

        public async Task<Boolean> isValid(Guid id)
        {
            var dataInvite = await getID(id);

            return isValid(dataInvite);
        }

        private bool isValid(Invite invite)
        {
            if (invite == null)
                return false;

            if (!invite.isActive)
                return false;

            return true;
        }


    }
}
