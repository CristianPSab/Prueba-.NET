using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SiliconPower.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
//using System.Web.Http;

namespace SiliconPower.FiltroAccion
{
    public class MiFiltroAccion : IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Se ejecuta antes de la acción

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Se ejecuta después de la acción


            bool ok = context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues auth);


            if (!ok) goto sinToken;
            if (auth.Count == 0) goto sinToken;
            string[] split = auth[0].Split(' ');

            string token = string.Empty;

            if (split.Length == 2) token = split[1]; // en caso de que llegue en formato "Bearer" AquiMiToken
            else token = auth[0]; // en caso de que llegue en formato "AquiMiToken"

            //if (split.Length == 2 && token != string.Empty)
            //{
            //    token = split[1]; // en caso de que llegue en formato "Bearer" AquiMiToken
            //}
            //else token = auth[0]; // en caso de que llegue en formato "AquiMiToken" 

            //token contiene el valor del token de la petición
            // TODO verifica token

            // Convert a null string.  
            DateTime myDateTime = DateTime.Now;
            var db = new ApiContext();
          //  var okToken = db.Tokens.Where(m => m.Token == token && m.Fecha > myDateTime).FirstOrDefault();

          //  var tokenHandler = new JwtSecurityTokenHandler();

            //if (okToken != null)
            //{

            //    return;

            //}
            //else
            //{
            //    goto sinToken;

            //}

        //return;

        sinToken:

            context.Result = new RedirectToActionResult("ErrorToken", "User", null);

            //Acción para hacer el error
            //TODO No tiene token

            //var response = new HttpResponseMessage
            //{
            //    Content =
            //                new StringContent("This token is not valid, please refresh token or obtain valid token!"),
            //    StatusCode = HttpStatusCode.Unauthorized,

            //};
            //throw new HttpResponseException(response);
            //return;

        }
    }
}
