using Ombe.Business.Interfaces;
using Ombe.Business.Models;
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

        public Task Adicionar(RatingInteractionType ratingInteractionType)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(RatingInteractionType ratingInteractionType)
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
