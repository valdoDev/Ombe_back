using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Business.Notifications;
using Ombe.Flow.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombe.Flow.Product
{
    public class Main : BaseFlow
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;

        public Main(INotifier notifier, IUserRepository userRepository, IProductRepository productRepository) : base(notifier)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
        }

        public async Task<Boolean> step1_ValidantionUser(Guid id)
        {
            var user = await new Business.Services.UserService(_notifier, _userRepository).getID(id);

            if (user == null)
                return false;

            if (!user.PermissionAdm)
                _notifier.Handle(new Notification("Usuário não possui permissão para executar função!"));

            return (user.PermissionAdm);

        }

        public async Task<Boolean> step2_Add(Business.Models.Product product, Guid idUser)
        {
            if (await step1_ValidantionUser(idUser))
                return false;

            await new Business.Services.ProductService(_notifier,_productRepository).Adicionar(product);

            return _notifier.hasNotification();

        }
    }
}
