using Core.Api.Controller;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SGCServeur.LibrairieBdd;
using SGCServeur.Models.Bdd;
using System;
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
            if (await dao.Contains(employe.Id))
            {
                return Conflict("An account with the same code already exists");
            }
            return await dao.Create(employe);
        }

        [HttpPut, Route("update/{id}")]
        [Description("Update the information of an employe")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(BadRequestResult), Description = "The Id is not given or the body is incorrect")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Update([FromRoute][Description("The id of the employe to modify")] Guid id, [FromBody][Description("The information to update")] Employe employe)
        {
            if (id == Guid.Empty || employe == null)
            {
                return new BadRequestResult();
            }
            return await dao.Update(employe, id);
        }

        [HttpDelete, Route("delete/{id}")]
        [Description("Delete an employe from the database")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The employe to delete wasn't found")]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(BadRequestResult), Description = "The id is not given or incorrect !")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Employe), Description ="The account deleted in the database")]
        public async Task<ActionResult<Employe>> Delete([FromRoute][Description("Id of the employe to delete")] Guid id)
        {
            if(id == Guid.Empty)
            {
                return new BadRequestResult();
            }
            /*if (!dao.Contains(id))
            {
                return NotFound("The employe to delete wasn't found");
            }*/
            return await dao.Delete(id);
        }

        [HttpGet]
        [Description("Give an employe from the database associated to the Id")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The employe to get wasn't found")]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(BadRequestResult), Description = "The id is not given or incorrect !")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Employe), Description = "The account found with the id")]
        public async Task<ActionResult<Employe>> GetById([FromQuery][Description("Id of the employe to get")] Guid id)
        {
            if (id == Guid.Empty)
            {
                return new BadRequestResult();
            }
            //if (!dao.Contains(id))
            //{
            //    return NotFound("The employe to delete wasn't found");
            //}
            return await dao.Read(id);
        }
    }
}
