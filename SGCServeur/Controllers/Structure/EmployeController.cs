using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SGCServeur.LibrairieBdd;
using SGCServeur.Models.Bdd;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace SGCServeur.Controllers
{
    [ApiController]
    [Route("api/struct/[controller]")]
    [OpenApiTag("Employe", Description = "Controller which allows to manipulate the data of the employe in the database")]
    public class EmployeController : ControllerBase
    {
        private EmployeDAO dao;

        public EmployeController(BaseTestContext context)
        {
            dao = new EmployeDAO(context);
        }

        [HttpPost, Route("create")]
        [Description("Create a new account in the database")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(ConflictResult), Description = "An account with the same code already exists")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Create([FromBody] Employe employe)
        {
            var result = await dao.Create(employe);
            if (!result)
            {
                return Conflict("An account with the same code already exists");
            }
            return result;
        }
    }
}
