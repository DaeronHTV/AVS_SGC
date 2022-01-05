using Core.Api.Helper;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SGCServeur.Models.Bdd;
using SGCServeur.Services;
using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace SGCServeur.Controllers.Services
{
    [Route("[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly SGCContext context;
        private readonly ExportService exportService;

        public ExportController(SGCContext context)
        {
            exportService = new ExportService(context);
        }

        [HttpGet]
        [Description("Give an employe from the database associated to the Id")]
        public async Task GetComptes([FromQuery][Description("list of value to take the account wanted by the user")] string value, 
            [FromQuery][Description("Tell if the value is code or guid")] bool byCode)
        {
            try
            {
                var values = value.Split(',');
                (string title, byte[] content) = await this.exportService.GetComptes(values, byCode);
                Response.Headers.Add(ConstApiHelper.ContentDisposition, string.Concat(ConstApiHelper.AttachmentFile, title));
                Response.Headers.Add(ConstApiHelper.ContentType, ConstApiHelper.XmlType);
                await Response.Body.WriteAsync(content, 0, content.Length);
            }
            catch (Exception e)
            {
                //TODO
            }
        }
    }
}
