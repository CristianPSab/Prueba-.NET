using Microsoft.EntityFrameworkCore;
using SiliconPower.Utils;
using SiliconPower.Models;

namespace SiliconPower.Data
{
    public class ApiContext : DbContext
    {
        //public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        //{

        //}

        public DbSet<UserModel> Users { get; set; } 

        public DbSet<ActividadUsuarioModel> actividadUsuarioModels { get; set; }

        public DbSet<ActividadesModel> actividades { get; set; }

        public DbSet<LocalizacionCoordenadasModel> localizacionCoordenadasModels { get; set; }
        
        public DbSet<ReservasModel> reservasModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dsn = ConfigUtils.DSN;
            optionsBuilder.UseSqlServer(dsn);
        }
    }
}
