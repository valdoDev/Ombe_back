using System;

namespace Ombe.Business.Models
{
    public record RatingInteraction : Entity
    {
        public Guid IdRating { get; set; }
        public Guid IdUserInteraction { get; set; }
        public Guid IdRatingInteractionType { get; set; }
    }
}
