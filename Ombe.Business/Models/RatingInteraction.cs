using System;

namespace Ombe.Business.Models
{
    public class RatingInteraction : Entity
    {
        public Guid IdRating { get; set; }
        public Guid IdUser { get; set; }
        public Guid IdRatingInteractionType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
    }
}
