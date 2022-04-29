using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiliconPower.Models
{
    [Table("LocalizacionCoordenadas")]
    public class LocalizacionCoordenadasModel
    {
        [Key]
        public Guid Id { get; set; }
        public float Longitud { get; set; }

        public float Latitud { get; set; }

        public float Unidad  { get; set; }
    }
}
