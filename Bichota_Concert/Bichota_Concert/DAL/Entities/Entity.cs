using System.ComponentModel.DataAnnotations;

namespace Bichota_Concert.DAL.Entities
{
    public class Entity
    {
        [Key] 
        [Required] 
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Fecha de Modificacion")]
        public DateTime? ModifiedDate { get; set; }
    }
}
