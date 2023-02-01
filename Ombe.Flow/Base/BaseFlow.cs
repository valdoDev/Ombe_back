using Ombe.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombe.Flow.Base
{
    public abstract class BaseFlow
    {
        
        protected readonly INotifier _notifier;

        protected BaseFlow(INotifier notifier)
        {
            _notifier = notifier;
        }
    }
}
