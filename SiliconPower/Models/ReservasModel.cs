using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiliconPower.Models
{
    [Table("reservas")]
    public class ReservasModel
    {
        
        [Key]   
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }

    }
}
