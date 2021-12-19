using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.DAO
{
    public class CommonDAO<T> : IDAO<T> where T : IBaseObject
    {
        private readonly DbContext context;

        public CommonDAO(DbContext context)
        {
            this.context = context;
        }

        public bool Contains(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(T objet)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Read(string id)
        {
            throw new NotImplementedException();
        }

        public IList<T> ReadAll(int nbPerPage = 10)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T objet, string id)
        {
            throw new NotImplementedException();
        }
    }
}
