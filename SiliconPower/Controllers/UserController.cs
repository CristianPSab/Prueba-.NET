using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiliconPower.Data;
using SiliconPower.Models;
using SiliconPower.RequestModels;
using SiliconPower.ResponseModels;
using SiliconPower.Utils;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiliconPower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly ApiContext _context;

        //public UserController(ApiContext context)
        //{
        //    _context = context;
        //}
        //[HttpGet]
        //public async Task<IActionResult> Registro()
        //{
        //    return View(await _context.Users.ToListAsync());
        //}
        

        // GET: api/<UserController>
        [HttpGet("{id}")]
        public ActionResult<DataModel> Get(Guid id)
        {
            try
            {
                
                return DataUtils.BuildDataModel(0); ;

            }
            catch (Exception)
            {
                return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.Unknown);
            }
        }

        // POST api/<UserController>
        [HttpPost("registro")]
        public ActionResult<DataModel> Registro([FromBody] UserRequestModel usuarioRequest)
        {
            if (usuarioRequest != null)
            {
                var usuario = new UserModel
                {
                    Usuario = usuarioRequest.Usuario,
                    Email = usuarioRequest.Email,
                    Password = usuarioRequest.Password
                };

                var db = new ApiContext();
                db.Users.Add(usuario);
                db.SaveChanges();

                return DataUtils.BuildDataModel(true, 0, "Usuario creado correctamente.");
            }
            else return DataUtils.BuildDataModel(false, 0, "No se puede dar de alta el artículo por que hay algún valor nulo ");
        }

        // PUT api/<UserController>/5
        [HttpPut("modificar/{id}")]
        public ActionResult<DataModel> Modificar(Guid id, [FromBody] UserRequestModel usuarioRequest)
        {

            try
            {
                if (usuarioRequest != null)
                {
                    var db = new ApiContext();
                    var usuario = db.Users.FirstOrDefault(x => x.Id == id);

                    if (usuario == null)
                    {

                        return DataUtils.BuildDataModel(DataUtils.PredefinedMessages.NonExist);
                    }


                    usuario.Usuario = usuarioRequest.Usuario;
                    usuario.Email = usuarioRequest.Email;
                    usuario.Password = usuarioRequest.Password;

                    db.SaveChanges();


                    return DataUtils.BuildDataModel(true, 0, "El usuario ha sido modificado correctamente.");

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
