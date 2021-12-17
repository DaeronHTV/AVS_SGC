using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SGCServeur.Models.Bdd;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SGCServeur.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [OpenApiTag("Api", Description = "Informations sur le serveur")]
    public class ApiController : ControllerBase
    {
        private BaseTestContext context;

        public ApiController(BaseTestContext context)
        {
            this.context = context;
        }

        [HttpGet, Route("version/api")]
        [Description("Retourne la version actuelle du serveur")]
        public ActionResult<string> GetVersion()
        {
            return "alpha";
        }

        [HttpGet, Route("version/dotnet")]
        [Description("Retourne la version dotnet")]
        public async Task<int> GetDotNetVersion()
        {
            return Environment.Version.Major;
        }

        [HttpGet, Route("database-info")]
        [Description("Retourne les informations sur la base de données")]
        public async Task<string> GetDatabaseInfo()
        {
            return null;
        }

        [HttpGet, Route("verison/database-schema")]
        public async Task<string> GetDatabaseVersion()
        {
            throw new Exception("Not Implemented Yet !");
        }
    }
}
