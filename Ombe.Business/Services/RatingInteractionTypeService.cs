using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class RatingInteractionTypeService : BaseService, IRatingInteractionTypeService
    {
        private readonly IRatingInteractionTypeRepository _ratingInteractionTypeRepository;

        public RatingInteractionTypeService(INotifier notifier,
            IRatingInteractionTypeRepository ratingInteractionTypeRepository) : base(notifier)
        {
            _ratingInteractionTypeRepository = ratingInteractionTypeRepository;
        }

        public async Task Adicionar(RatingInteractionType ratingInteractionType)
        {
            if (!ExecutarValidacao(new RatingInteractionTypeValidation(), ratingInteractionType)) return;

            await _ratingInteractionTypeRepository.Adicionar(ratingInteractionType);
        }

        public async Task Atualizar(RatingInteractionType ratingInteractionType)
        {
            if (!ExecutarValidacao(new RatingInteractionTypeValidation(), ratingInteractionType)) return;

            await _ratingInteractionTypeRepository.Atualizar(ratingInteractionType);
        }

        public async Task Remover(Guid id)
        {
            await _ratingInteractionTypeRepository.Remover(id);
        }

        public void Dispose()
        {
            _ratingInteractionTypeRepository?.Dispose();
        }

        public async Task<RatingInteractionType> getID(Guid id)
        {
            return await _ratingInteractionTypeRepository.ObterPorId(id);
        }
    }
}
