using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Controller
{
    public interface IObjectController<T> where T: BaseObject
    {

        Task<ActionResult<bool>> Update([FromBody] T objet, [FromRoute] string id);

        Task<ActionResult<bool>> Create([FromBody] T objet);

        Task<ActionResult<T>> Delete([FromRoute] string id);

        Task<ActionResult<T>> GetById([FromQuery] string id);

        Task<ActionResult<T>> GetByCode([FromQuery] string code);

        Task<ActionResult<IList<T>>> GetAll();
    }
}
