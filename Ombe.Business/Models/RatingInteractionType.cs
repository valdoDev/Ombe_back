using System;

namespace Ombe.Business.Models
{
    public class RatingInteractionType : Entity
    {
        public string value { get; set; }
        public string description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
    }
}
