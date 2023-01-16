using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class PaternService : BaseService, IPaternService
    {
        private readonly IPaternRepository _paternRepository;

        public PaternService(INotifier notifier,
            IPaternRepository paternRepository) : base(notifier)
        {
            _paternRepository = paternRepository;
        }

        public Task Adicionar(Patern patern)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Patern patern)
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
