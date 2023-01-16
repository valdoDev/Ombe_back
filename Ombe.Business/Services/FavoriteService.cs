using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class FavoriteService : BaseService, IFavoriteService
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteService(IFavoriteRepository favoriteRepository,
                                INotifier notifier) : base(notifier)
        {
            _favoriteRepository = favoriteRepository;
        }

        public async Task Adicionar(Favorite favorite)
        {
            if (!ExecutarValidacao(new FavoriteValidation(), favorite)) return;

            //var user = _user.GetUserId();

            await _favoriteRepository.Adicionar(favorite);
        }

        public Task Atualizar(Favorite favorite)
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
