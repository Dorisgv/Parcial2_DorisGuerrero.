using System.ComponentModel.DataAnnotations;

namespace Bichota_Concert.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Fecha de uso de la Boleta")]
        public DateTime? UseDate { get; set; }
        [Display(Name = "Estado de la Boleta")]
        public bool IsUsed { get; set; }
        [Display(Name = "Puerta de Entrada")]
        public string? EntranceGate { get; set; }



    }
}
