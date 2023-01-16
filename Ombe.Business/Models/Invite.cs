using System.ComponentModel.DataAnnotations;

namespace Ombe.Business.Models
{
    public class Invite : Entity
    {
        [StringLength(200)]
        public string Code { get; set; }
    }
}
