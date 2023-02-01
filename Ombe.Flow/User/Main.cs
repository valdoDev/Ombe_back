using Ombe.Business.Interfaces;
using Ombe.Flow.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ombe.Business.Services;
using Ombe.Business.Notifications;

namespace Ombe.Flow.User
{
    public class Main : BaseFlow
    {
        private readonly IUserRepository _userRepository;
        private readonly IInviteRepository _inviteRepository;

        public Main(INotifier notifier, 
                    IUserRepository userRepository,
                    IInviteRepository inviteRepository) : base(notifier)
        {
            _userRepository = userRepository;
            _inviteRepository = inviteRepository;
        }

        public async Task<bool> Create(Business.Models.User user, string codeInvite)
        {
            
            var userService = new UserService(_notifier, _userRepository);

            var dadosUser = await userService.getID(user.Id);

            if (!(dadosUser == null))
            {
                _notifier.Handle(new Notification("Usuário já existente na base!"));
                return false;
            }

            var inviteService = new InviteService(_notifier, _inviteRepository);
            var inviteList = await inviteService.getCodeFirst(codeInvite);

            if(inviteList == null)
            {
                _notifier.Handle(new Notification("Código do convite inválido ou utilizado!"));
                return false;
            }

            user.IdInvite = inviteList.Id;

            await userService.Adicionar(user);

            return !_notifier.hasNotification();


        }

        public async Task<bool> Update(Business.Models.User user)
        {

            var userService = new UserService(_notifier, _userRepository);

            var dadosUser = await userService.getID(user.Id);

            if (dadosUser == null)
            {
                _notifier.Handle(new Notification("Usuário não existente na base!"));
                return false;
            }

            await userService.Atualizar(user);

            return !_notifier.hasNotification();

        }



    }
}
