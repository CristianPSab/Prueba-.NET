using Microsoft.AspNetCore.Mvc;
using SiliconPower.Data;
using SiliconPower.Models;
using SiliconPower.ResponseModels;
using SiliconPower.Utils;

namespace SiliconPower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {



        // GET: api/<ActividadesController>
        [HttpGet("{id}")]
        public ActionResult<DataModel> Get(Guid id)
        {
            try
            {


                ApiContext db = new();
                var actividades = db.actividades.FirstOrDefault(x => x.Id == id);
                if (actividades == null)
                {
                    //TODO ERROR
                    return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.NonExist);

                }
                return DataUtils.BuildDataModel(actividades); ;

            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }

        
        //// GET: api/<ActividadesController>
        //[HttpGet("{idLocalizacion}{categorias}")]
        //public ActionResult<DataModel> Get(Guid idLocalizacion, string categorias)
        //{
        //    try
        //    {
        //        ApiContext db = new();

        //        var actividades = db.actividades.Select(x => x.IdLocalizacion == idLocalizacion && x.Categorias == categorias);
        //        if (actividades == null)
        //        {
        //            //TODO ERROR
        //            return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.NonExist);
        //        }
        //        return DataUtils.BuildDataModel(actividades);

        //    }
        //    catch (Exception)
        //    {
        //        return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
        //    }
        //}

    }
}
