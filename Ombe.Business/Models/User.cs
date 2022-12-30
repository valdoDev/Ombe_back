using System;

namespace Ombe.Business.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string email { get; set; }
        public Guid IdInvite { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool isActive { get; set; }
    }
}
