using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IFavoriteService : IDisposable
    {
        Task Adicionar(Favorite favorite);
        Task Atualizar(Favorite favorite);
        Task Remover(Guid id);
        Task<Favorite> getID(Guid id);
    }
}
