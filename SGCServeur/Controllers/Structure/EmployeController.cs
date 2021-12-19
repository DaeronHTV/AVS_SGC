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

        public EmployeController(SGCContext context)
        {
            dao = new EmployeDAO(context);
        }

        [HttpPost, Route("create")]
        [Description("Create a new account in the database")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(ConflictResult), Description = "An account with the same code already exists")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Create([FromBody][Description("The employe to add in the databse")] Employe employe)
        {
            if (dao.Contains(employe.Code))
            {
                return Conflict("An account with the same code already exists");
            }
            return await dao.Create(employe);
        }

        [HttpPut, Route("update/{id}")]
        [Description("Update the information of an employe")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(BadRequestResult), Description = "The Id is not given or the body is incorrect")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Update([FromRoute][Description("The id of the employe to modify")] string id, [FromBody][Description("The information to update")] Employe employe)
        {
            if (string.IsNullOrWhiteSpace(id) || employe == null)
            {
                return BadRequest("The id or the body is not given or incorrect !");
            }
            return await dao.Update(employe, id);
        }

        [HttpDelete, Route("delete/{id}")]
        [Description("Delete an employe from the database")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The employe to delete wasn't found")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Employe), Description ="The account deleted in the database")]
        public async Task<ActionResult<Employe>> Delete([FromRoute][Description("Id of the employe to delete")] string id)
        {
            if (!dao.Contains(id))
            {
                return NotFound("The employe to delete wasn't found");
            }
            return await dao.Delete(id);
        }

        [HttpGet]
        [Description("Give an employe from the database associated to the Id")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The employe to get wasn't found")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Employe), Description = "The account found with the id")]
        public async Task<ActionResult<Employe>> GetById([FromQuery][Description("Id of the employe to get")] string id)
        {
            if (!dao.Contains(id))
            {
                return NotFound("The employe to delete wasn't found");
            }
            return await dao.Read(id);
        }
    }
}
