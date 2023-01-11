using System;

namespace Ombe.Business.Models
{
    public class RatingInteraction : Entity
    {
        public Guid IdRating { get; set; }
        public Guid IdUserInteraction { get; set; }
        public Guid IdRatingInteractionType { get; set; }
    }
}
