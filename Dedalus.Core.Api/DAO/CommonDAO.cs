using System;
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

        public Task<bool> Create(T objet)
        {
            throw new NotImplementedException();
        }

        public T Delete(string id)
        {
            throw new NotImplementedException();
        }

        public T Read(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T objet, string id)
        {
            throw new NotImplementedException();
        }
    }
}
