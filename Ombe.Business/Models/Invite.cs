using System;

namespace Ombe.Business.Models
{
    public class Invite : Entity
    {
        public string Code { get; set; }
        public bool isAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
    }
}
