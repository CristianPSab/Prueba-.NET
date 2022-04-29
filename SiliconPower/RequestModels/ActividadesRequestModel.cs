namespace SiliconPower.RequestModels
{
    public class ActividadesRequestModel
    {
        public string GaleriaDeImagenes { get; set; }
        public string Descripcion { get; set; }

        public string Categorias { get; set; }

        public double Precio { get; set; }

        public Guid IdLocalizacion { get; set; }

        public DateTime Fecha { get; set; }

        public Guid IdReserva { get; set; }
    }
}
