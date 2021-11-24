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
    [Route("[controller]")]
    [OpenApiTag("Service", Description = "Gestion des services")]
    public class ServiceController : ControllerBase
    {
        public ServiceController()
        {
        }

        [HttpGet]
        [Route("{id}")]
        [Description("Récupère le service associé via son Id")]
        public async Task<string> GetServiceById([FromRoute]string id)
        {
            return null;
        }

        [HttpGet]
        [Route("{code}")]
        [Description("Récupère le service en fonction de son code")]
        public async Task<string> GetServiceByCode([FromRoute]string code)
        {
            return null;
        }

        [HttpPost, Route("create")]
        [Description("Créer un nouveau service en base de données")]
        public async Task CreateService([FromBody]string service)
        {

        }
    }
}
