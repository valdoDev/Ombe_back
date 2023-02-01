using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IPaternService : IDisposable
    {
        Task Adicionar(Patern patern);
        Task Atualizar(Patern patern);
        Task Remover(Guid id);
        Task<Patern> getID(Guid id);
    }
}
