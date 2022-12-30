using System;

namespace Ombe.Business.Models
{
    public class Products : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Published { get; set; }
        public int IdNCM { get; set; }
    }
}
