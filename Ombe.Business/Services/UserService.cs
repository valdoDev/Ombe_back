using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
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

        public async Task Adicionar(User user)
        {
            if (!ExecutarValidacao(new UserValidation(), user)) return;

            await _userRepository.Adicionar(user);
        }

        public async Task Atualizar(User user)
        {
            if (!ExecutarValidacao(new UserValidation(), user)) return;

            await _userRepository.Atualizar(user);
        }

        public async Task<User> getID(Guid id)
        {
            return await _userRepository.ObterPorId(id);
        }

        public async Task Remover(Guid id)
        {
            await _userRepository.Remover(id);
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }
    }
}
