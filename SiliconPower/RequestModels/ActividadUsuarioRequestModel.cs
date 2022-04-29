namespace SiliconPower.RequestModels
{
    public class ActividadUsuarioRequestModel
    {
        public double Puntuacion { get; set; }

        public string Comentarios { get; set; }

        public Guid IdUsuario { get; set; }

        public Guid IdActividad { get; set; }
    }
}
