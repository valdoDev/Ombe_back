using Ombe.Business.Interfaces;
using Ombe.Business.Models;
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

        public Task Adicionar(RatingInteraction ratingInteraction)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(RatingInteraction ratingInteraction)
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
