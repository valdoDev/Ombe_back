using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task Adicionar(User user);
        Task Atualizar(User user);
        Task Remover(Guid id);
        Task<User> getID(Guid id);
    }
}
