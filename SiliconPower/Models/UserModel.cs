using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiliconPower.Models
{
    [Table("Usuarios")]
    public class UserModel
    {
        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid Id { get; set; }
        public string Usuario { get; set; }

        [Required (ErrorMessage = "El correo electrónico es obligatorio")]
        public  string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }


    }
}
