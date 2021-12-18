using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.Controllers
{
    [ApiController]
    [Route("api/struct/[controller]")]
    [OpenApiTag("Service", Description = "Gestion des services")]
    public class ServiceController : ControllerBase
    {
        public ServiceController()
        {
        }

        [HttpGet]
        [Route("{id}")]
        [Description("Get the service by it Id")]
        public async Task<string> GetServiceById([FromRoute][Description("Id of the service needed")]string id)
        {
            throw new NotImplementedException("Not Impleted Yet !");
        }

        [HttpGet]
        [Route("{code}")]
        [Description("Get the service by the code")]
        public async Task<string> GetServiceByCode([FromRoute][Description("The code of the service")]string code)
        {
            throw new NotImplementedException("Not Impleted Yet !");
        }

        [HttpPost, Route("create")]
        [Description("Créer un nouveau service en base de données")]
        public async Task CreateService([FromBody]string service)
        {
            throw new NotImplementedException("Not Impleted Yet !");
        }
    }
}
