using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IRatingInteractionService : IDisposable
    {
        Task Adicionar(RatingInteraction ratingInteraction);
        Task Atualizar(RatingInteraction ratingInteraction);
        Task Remover(Guid id);
    }
}
