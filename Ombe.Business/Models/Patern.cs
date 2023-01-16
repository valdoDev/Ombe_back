using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public class Patern : Entity
    {
        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string StreetAvenue { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(200)]
        public string Neighborhood { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(200)]
        public string GeographicalCoordinates { get; set; }
    }
}
