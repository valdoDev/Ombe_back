using System;

namespace Ombe.Business.Models
{
    public class Paterns : Entity
    {
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public string StreetAvenue { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string GeographicalCoordinates { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
    }
}
