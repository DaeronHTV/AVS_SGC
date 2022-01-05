using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SGCServeur.LibrairieBdd;
using SGCServeur.Models.Bdd;
using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace SGCServeur.Controllers.Structure
{
    [ApiController]
    [Route("api/struct/[controller]")]
    [OpenApiTag("Compte", Description = "Controller which allows to manipulate the data of account in database")]
    public class CompteController : ControllerBase
    {
        private readonly CompteDAO dao;

        public CompteController(SGCContext context)
        {
            dao = new CompteDAO(context);
        }

        [HttpPut]
        [Route("update/{id}")]
        [Description("Update the information about an account")]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(BadRequestResult), Description = "Id or data not given well")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The account to update doesn't exist")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was updated with success")]
        public async Task<ActionResult<bool>> Update([Description("Datas to update")][FromBody] Compte compte, [Description("Account's Id")][FromRoute] string id)
        {
            return null;
        }

        [HttpPost, Route("create")]
        [Description("Create a new account in the database")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(ConflictResult), Description = "An account with the same code already exists")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Create([FromBody] Compte compte)
        {
            if (await dao.Contains(compte.Id))
            {
                return Conflict("An account with the same code already exists");
            }
            return await dao.Create(compte);
        }

        [HttpDelete, Route("delete/{id}")]
        [Description("Delete an account from the database")]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(NotFoundResult), Description = "The account to delete wasn't found")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Compte), Description = "The account deleted in the database")]
        public async Task<ActionResult<Compte>> Delete([FromRoute][Description("Id of the account to delete")] Guid id)
        {
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
        [SwaggerResponse(HttpStatusCode.OK, typeof(Compte), Description = "The account found with the id")]
        public async Task<ActionResult<Compte>> GetById([FromQuery][Description("Id of the employe to get")] Guid id)
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
