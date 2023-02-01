using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IRatingService : IDisposable
    {
        Task Adicionar(Rating rating);
        Task Atualizar(Rating rating);
        Task Remover(Guid id);
        Task<Rating> getID(Guid id);
    }
}
