using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Models.Validations;
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

        public async Task Adicionar(Product produto)
        {
            if (!ExecutarValidacao(new ProductValidation(), produto)) return;

            await _productRepository.Adicionar(produto);
        }

        public async Task Atualizar(Product produto)
        {
            if (!ExecutarValidacao(new ProductValidation(), produto)) return;

            await _productRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _productRepository.Remover(id);
        }

        public void Dispose()
        {
            _productRepository?.Dispose();
        }

        public async Task<Product> getID(Guid id)
        {
            return await _productRepository.ObterPorId(id);
        }
    }
}
