using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public class RatingInteractionType : Entity
    {
        [StringLength(10)]
        public string Value { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
