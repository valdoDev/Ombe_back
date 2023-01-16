using System;
using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public class User : Entity
    {
        public Guid IdInvite { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        [StringLength(200)]
        public string Email { get; set; }
    }
}
