using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Location.API.Utils
{
    public class ControllerExtensions
    {
        public static IActionResult HttpResult<T>(ControllerBase controller, HttpStatusCode code, T data)
        => code switch
        {
            HttpStatusCode.OK => controller.Ok(data),
            HttpStatusCode.BadRequest => controller.BadRequest(data),
            HttpStatusCode.Forbidden => controller.Forbid(),
            HttpStatusCode.InternalServerError => controller.StatusCode((int)code, data),
            HttpStatusCode.NotFound => controller.NotFound(data),
            _ => controller.Conflict()
        };
    }
}
