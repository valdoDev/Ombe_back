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

            await _favoriteRepository.Adicionar(favorite);
        }

        public async Task Atualizar(Favorite favorite)
        {
            if (!ExecutarValidacao(new FavoriteValidation(), favorite)) return;

            await _favoriteRepository.Atualizar(favorite);
        }

        public async Task Remover(Guid id)
        {
            await _favoriteRepository.Remover(id);
        }

        public void Dispose()
        {
            _favoriteRepository?.Dispose();
        }

        public async Task<Favorite> getID(Guid id)
        {
            return await _favoriteRepository.ObterPorId(id);
        }
    }
}
