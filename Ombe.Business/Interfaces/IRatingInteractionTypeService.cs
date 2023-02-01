using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IRatingInteractionTypeService : IDisposable
    {
        Task Adicionar(RatingInteractionType ratingInteractionType);
        Task Atualizar(RatingInteractionType ratingInteractionType);
        Task Remover(Guid id);
        Task<RatingInteractionType> getID(Guid id);
    }
}
