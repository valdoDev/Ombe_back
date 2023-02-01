using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class RatingInteractionService : BaseService, IRatingInteractionService
    {
        private readonly IRatingInteractionRepository _ratingInteractionRepository;

        public RatingInteractionService(INotifier notifier,
            IRatingInteractionRepository ratingInteractionRepository) : base(notifier)
        {
            _ratingInteractionRepository = ratingInteractionRepository;
        }

        public async Task Adicionar(RatingInteraction ratingInteraction)
        {
            if (!ExecutarValidacao(new RatingInteractionValidation(), ratingInteraction)) return;

            await _ratingInteractionRepository.Adicionar(ratingInteraction);
        }

        public async Task Atualizar(RatingInteraction ratingInteraction)
        {
            if (!ExecutarValidacao(new RatingInteractionValidation(), ratingInteraction)) return;

            await _ratingInteractionRepository.Atualizar(ratingInteraction);
        }

        public void Dispose()
        {
            _ratingInteractionRepository?.Dispose();
        }

        public async Task<RatingInteraction> getID(Guid id)
        {
            return await _ratingInteractionRepository.ObterPorId(id);
        }

        public async Task Remover(Guid id)
        {
            await _ratingInteractionRepository.Remover(id);
        }
    }
}
