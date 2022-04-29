using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiliconPower.Models
{
    [Table("ActividadUsuario")]
    public class ActividadUsuarioModel
    {

        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
            
        public double Puntuacion { get; set; }

        public string Comentarios { get; set; }

        public Guid IdUsuario { get; set; }

        public Guid IdActividad { get; set; }

        [ForeignKey("Usuarios")]

        public UserModel user { get; set; }

        [ForeignKey("Actividades")]
        public ActividadesModel actividades { get; set; }
    }
}
