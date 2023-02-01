using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IInviteService : IDisposable
    {
        Task Adicionar(Invite invite);
        Task Atualizar(Invite invite);
        Task Remover(Guid id);
        Task<Invite> getID(Guid id);
        Task<Invite> getCodeFirst(String code);
        Task<Boolean> isValid(Guid id);
    }
}
