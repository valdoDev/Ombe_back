using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class RatingService : BaseService, IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(INotifier notifier,
            IRatingRepository ratingRepository) : base(notifier)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task Adicionar(Rating rating)
        {
            if (!ExecutarValidacao(new RatingValidation(), rating)) return;

            await _ratingRepository.Adicionar(rating);
        }

        public async Task Atualizar(Rating rating)
        {
            if (!ExecutarValidacao(new RatingValidation(), rating)) return;

            await _ratingRepository.Atualizar(rating);
        }

        public async Task Remover(Guid id)
        {
            await _ratingRepository.Remover(id);
        }

        public void Dispose()
        {
            _ratingRepository?.Dispose();
        }

        public async Task<Rating> getID(Guid id)
        {
            return await _ratingRepository.ObterPorId(id);
        }
    }
}
