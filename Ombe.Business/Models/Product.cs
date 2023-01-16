using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public class Product : Entity
    {
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public int? IdNCM { get; set; }
        public List<Patern> Paterns { get; set; }
    }
}
