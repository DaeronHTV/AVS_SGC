using Core.Api.DAO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Api.Controller
{
    public class CommonController<T> : IObjectController<T> where T : IBaseObject
    {
        protected readonly IDAO<T> dao;

        public CommonController(IDAO<T> dao)
        {
            this.dao = dao;
        }

        public virtual async Task<ActionResult<bool>> Create([FromBody] T objet)
        {
            if (await dao.Contains(objet.Id))
            {
                return new ConflictResult();
            }
            return await dao.Create(objet);
        }

        public virtual Task<ActionResult<T>> Delete([FromRoute] string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ActionResult<IList<T>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<ActionResult<T>> GetByCode([FromQuery] string code)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ActionResult<T>> GetById([FromQuery] string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ActionResult<bool>> Update([FromBody] T objet, [FromRoute] string id)
        {
            throw new NotImplementedException();
        }
    }
}
