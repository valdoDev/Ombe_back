using System;
using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public record Rating : Entity
    {
        public Guid IdProduct { get; set; }
        public Guid IdUser { get; set; }
        public int Grade { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
