using System.ComponentModel.DataAnnotations;

namespace Bichota_Concert.DAL.Entities
{
    public class Entity
    {
        [Key] //Esto son datanotations, debe ubicarse encima de la propiedad que va hacer mi PK.
        [Required] //Este significa que el campo Id es requerido.
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; } //el signo de pregunta quiere decir que esos datos pueden ser nulos.
        public DateTime? ModifiedDate { get; set; }
    }
}
