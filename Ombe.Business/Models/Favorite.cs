using System;

namespace Ombe.Business.Models
{
    public class Favorite : Entity
    {
        public Guid IdProduct { get; set; }
        public Guid IdUser { get; set; }
    }
}
