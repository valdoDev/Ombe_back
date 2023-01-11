using System;

namespace Ombe.Business.Models
{
    public class User : Entity
    {
        public Guid IdInvite { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string email { get; set; }
    }
}
