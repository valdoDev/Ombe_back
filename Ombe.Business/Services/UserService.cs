using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(INotifier notifier,
            IUserRepository userRepository) : base(notifier)
        {
            _userRepository = userRepository;
        }

        public Task Adicionar(User user)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(User user)
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
