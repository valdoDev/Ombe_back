using System;
using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public abstract record Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [StringLength(200)]
        public String CreatedBy { get; set; }

        [StringLength(200)]
        public String UpdatedBy { get; set; }

        public bool isActive { get; set; }
    }
}
