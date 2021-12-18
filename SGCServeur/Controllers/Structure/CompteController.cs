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

        public CompteController(BaseTestContext context)
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
            if (string.IsNullOrWhiteSpace(id) || compte is null)
            {
                return BadRequest();
            }
            else if (!dao.Contains(id, out Compte result))
            {
                return NotFound();
            }
            return dao.Update(compte);
        }

        [HttpPost, Route("create")]
        [Description("Create a new account in the database")]
        [SwaggerResponse(HttpStatusCode.Conflict, typeof(ConflictResult), Description = "An account with the same code already exists")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "The account was created with success")]
        public async Task<ActionResult<bool>> Create([FromBody] Compte compte)
        {
            if (dao.Contains(compte.Employe.Code))
            {
                return Conflict();
            }
            return dao.Create(compte);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<Compte>> Delete([FromRoute] string id)
        {
            throw new NotImplementedException();
        }
    }
}
