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
    public class ReservasController : Controller
    {
        //GET: api/<ActividadUsuarioController>
        [HttpGet]

        public ActionResult<DataModel> GetList()
        {
            try
            {
                ReservasModel model = new();

                ApiContext db = new();
                List<ReservasModel> reservas;
                reservas = db.reservasModels.ToList();

                return DataUtils.BuildDataModel(reservas);

            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }

        // POST api/<ActividaddController>
        [HttpPost("Alta")]
        public ActionResult<DataModel> Alta([FromBody] ReservasRequestModel reservasRequest)
        {
            try
            {
                if (reservasRequest != null)
                {
                   
                    
                    return DataUtils.BuildDataModel(true, 0);

                }
                else return DataUtils.BuildDataModel(false, 0, "No se puede dar de alta el artículo por que hay algún valor nulo ");
            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }
       

        // PUT api/<ReservasController>/5
        [HttpPut("modificar/{id}")]
        public ActionResult<DataModel> Modificar(Guid id, [FromBody] ReservasRequestModel reservasRequest)
        {

            try
            {
                if (reservasRequest != null)
                {



                    return DataUtils.BuildDataModel(0);

                }
                else return DataUtils.BuildDataModel(false, 0, "No se puede modificar el usuario por que hay algún valor nulo ");



            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }

        }

     
    }
}
