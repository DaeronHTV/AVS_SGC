using Core.Api.DAO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Api.Controller
{
    public class CommonController<T> : ControllerBase, IObjectController<T> where T : BaseObject
    {
        private readonly IDAO<T> dao;

        public CommonController(IDAO<T> dao)
        {
            this.dao = dao;
        }

        public Task<ActionResult<bool>> Create([FromBody] T objet)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<T>> Delete([FromRoute] string id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IList<T>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<T>> GetByCode([FromQuery] string code)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<T>> GetById([FromQuery] string id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<bool>> Update([FromBody] T objet, [FromRoute] string id)
        {
            throw new NotImplementedException();
        }
    }
}
