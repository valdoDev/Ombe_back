using System;

namespace Ombe.Business.Models
{
    public record Favorite : Entity
    {
        public Guid IdProduct { get; set; }
        public Guid IdUser { get; set; }
    }
}
