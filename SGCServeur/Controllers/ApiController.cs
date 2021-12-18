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
    [OpenApiTag("Api", Description = "Information about the server")]
    public class ApiController : ControllerBase
    {
        private BaseTestContext context;

        public ApiController(BaseTestContext context)
        {
            this.context = context;
        }

        [HttpGet, Route("version/api")]
        [Description("Give the current version of the server")]
        public ActionResult<string> GetVersion()
        {
            return "alpha";
        }

        [HttpGet, Route("version/dotnet")]
        [Description("Give the dotnet version used by the server")]
        public async Task<int> GetDotNetVersion()
        {
            return Environment.Version.Major;
        }

        [HttpGet, Route("verison/database-schema")]
        [Description("Give the version of the database")]
        public async Task<string> GetDatabaseVersion()
        {
            throw new Exception("Not Implemented Yet !");
        }
    }
}
