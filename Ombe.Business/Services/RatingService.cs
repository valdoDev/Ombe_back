using Ombe.Business.Interfaces;
using Ombe.Business.Models;
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

        public Task Adicionar(Rating rating)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Rating rating)
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
