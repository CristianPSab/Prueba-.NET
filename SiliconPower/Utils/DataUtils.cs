using SiliconPower.ResponseModels;

namespace SiliconPower.Utils
{
   
    public class DataUtils
    {


        public enum PredefinedMessages
        {
            OK = 0,
            Unknown = -1,
            AccessDenied = -2,
            NotFound = -3,
            InvalidLogin = -4,
            InvalidSession = -5,
            ExpiredSession = -6,
            MissingParameters = -7,
            LimitReached = -8,
            NonExist = -9
        }

        public static DataModel BuildDataModel(object data, int code = 0, string message = "")
        {
            try
            {
                var dm = new DataModel
                {
                    Data = data,
                    Status = new StatusModel() { Code = code, Message = message }
                };
                return dm;
            }
            catch (Exception)
            {
                //TODO LOG

                DataModel dm = new();
                dm.Status = new StatusModel() { Code = -1, Message = "Se ha producido un error desconocido." };
                return dm;
            }
        }

        public static DataModel BuildDataModel(PredefinedMessages type, Exception exception = null)
        {
            try
            {
                var status = new StatusModel();

                if (ConfigUtils.IsDebug && exception != null)
                {
                    status.Code = -99;
                    status.Message = $"{GetMessage(type)}\n{exception}";
                }
                else
                {
                    status.Code = GetCode(type);
                    status.Message = GetMessage(type);
                }

                var data = new DataModel()
                {
                    Data = null,
                    Status = status
                };
                return data;
            }
            catch (Exception)
            {
                //TODO LOG
                DataModel dm = new();
                dm.Status = new StatusModel() { Code = -1, Message = "Se ha producido un error desconocido." };
                return dm;
            }
        }

        public static int GetCode(PredefinedMessages type)
        {
            return (int)type;
        }

        public static string GetMessage(PredefinedMessages type)
        {
            return type switch
            {
                PredefinedMessages.OK => "OK.",
                PredefinedMessages.AccessDenied => "No tienes permiso para esta sección.",
                PredefinedMessages.NotFound => "El objeto que buscas no existe.",
                PredefinedMessages.InvalidLogin => "El usuario o la contraseña introducida no es válida.",
                PredefinedMessages.InvalidSession => "La sesión no es válida, por favor, vuelve a hacer login.",
                PredefinedMessages.ExpiredSession => "La sesión ha expirado, por favor, vuelve a hacer login.",
                PredefinedMessages.MissingParameters => "No se han especificado los parámetros requeridos.",
                PredefinedMessages.LimitReached => "Se ha sobrepasado el límite establecido.",
                PredefinedMessages.NonExist => "No existe en la base de datos",
                _ => "Se ha producido un error desconocido.",
            };
        }
    }
}
