using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiliconPower.Models
{

    [Table("Actividades")]
    public class ActividadesModel
    {
        [Key]

        public Guid Id { get; set; }
        
        public string GaleriaDeImagenes { get; set; }
        public string Descripcion { get; set; }

        public string Categorias { get; set; }
        
        public double Precio { get; set; }

        public Guid IdLocalizacion { get; set; }

        public DateTime Fecha { get; set; }

        public Guid IdReserva { get; set; }


        [ForeignKey("IdLocalizacion")]

        public LocalizacionCoordenadasModel localizacionCoordenadas { get; set; }

        [ForeignKey("IdReserva")]

        public ReservasModel Reservas { get; set; }
    }
}
