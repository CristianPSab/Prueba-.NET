using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiliconPower.Data;
using SiliconPower.Models;
using SiliconPower.RequestModels;
using SiliconPower.ResponseModels;
using SiliconPower.Utils;

namespace SiliconPower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadUsuarioController : Controller
    {


        //GET: api/<ActividadUsuarioController>
        [HttpGet]

        public ActionResult<DataModel> GetList()
        {
            try
            {
                ActividadUsuarioModel model = new();

                ApiContext db = new();
                List<ActividadUsuarioModel> actividadUsuario;
                actividadUsuario = db.actividadUsuarioModels.ToList();

                return DataUtils.BuildDataModel(actividadUsuario);

            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }

        // POST api/<ActividadController>
        [HttpPost("Alta")]
        public ActionResult<DataModel> Alta([FromBody] ActividadUsuarioRequestModel actividadUsuarioRequest)
        {
            try
            {
                if (actividadUsuarioRequest != null)
                {
                    var actividadUsuario = new ActividadUsuarioModel
                    {
                        Puntuacion = actividadUsuarioRequest.Puntuacion,
                        Comentarios = actividadUsuarioRequest.Comentarios
                        
                    };
                    var db = new ApiContext();
                    db.actividadUsuarioModels.Add(actividadUsuario);
                    db.SaveChanges();

                    return DataUtils.BuildDataModel(true, 0, "Artículo creado correctamente.");

                }
                else return DataUtils.BuildDataModel(false, 0, "No se puede dar de alta el artículo por que hay algún valor nulo ");
            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }


        // PUT api/<ActividadUsuarioController>/5
        [HttpPut("modificar/{id}")]
        public ActionResult<DataModel> Modificar(Guid id, [FromBody] ActividadUsuarioRequestModel actividadUsuarioRequest)
        {

            try
            {
                if (actividadUsuarioRequest != null)
                {
                   


                    return DataUtils.BuildDataModel( 0);

                }
                else return DataUtils.BuildDataModel(false, 0, "No se puede modificar el usuario por que hay algún valor nulo ");



            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }

        }

        // DELETE api/<ActividadUsuarioController>/5
        [HttpDelete("baja/{id}")]
        public ActionResult<DataModel> Baja(Guid id)
        {
            try
            {
               
               

                return DataUtils.BuildDataModel(true, 0);
            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }


        }

    }
}
