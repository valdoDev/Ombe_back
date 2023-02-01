using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Interfaces
{
    public interface IProductService : IDisposable
    {
        Task Adicionar(Product produto);
        Task Atualizar(Product produto);
        Task Remover(Guid id);
        Task<Product> getID(Guid id);
    }
}
