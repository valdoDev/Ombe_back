using System;

namespace Ombe.Business.Models
{
    public class Rating : Entity
    {
        public Guid IdProduct { get; set; }
        public Guid IdUser { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }
    }
}
