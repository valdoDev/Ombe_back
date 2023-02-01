using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
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

        public async Task Adicionar(Patern patern)
        {
            if (!ExecutarValidacao(new PaternValidation(), patern)) return;

            await _paternRepository.Adicionar(patern);
        }

        public async Task Atualizar(Patern patern)
        {
            if (!ExecutarValidacao(new PaternValidation(), patern)) return;

            await _paternRepository.Atualizar(patern);
        }

        public async Task Remover(Guid id)
        {
            await _paternRepository.Remover(id);
        }

        public void Dispose()
        {
            _paternRepository?.Dispose();
        }

        public async Task<Patern> getID(Guid id)
        {
            return await _paternRepository.ObterPorId(id);
        }
    }
}
