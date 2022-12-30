using System;

namespace Ombe.Business.Models
{
    public class Favorite : Entity
    {
        public Guid IdProduct { get; set; }
        public Guid IdUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
    }
}
