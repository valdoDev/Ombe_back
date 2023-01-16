using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using System;
using System.Threading.Tasks;

namespace Ombe.Business.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(INotifier notifier,
            IProductRepository productRepository) : base(notifier)
        {
            _productRepository = productRepository;
        }

        public Task Adicionar(Product produto)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Product produto)
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
